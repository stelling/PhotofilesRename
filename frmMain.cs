using System;
using System.IO;
using System.Drawing.Imaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Xml;
using System.ComponentModel;

namespace PhotofilesRename
{
	public partial class frmMain : Form
	{
		private static Regex r = new Regex(":");
		DataTable dtCamera = new DataTable("Camera");
		string XMLfile = string.Format(@"{0}Camera.xml", Application.StartupPath);

		public frmMain()
		{
			InitializeComponent();
		}
			
		private void frmMain_Load(object sender, EventArgs e)
		{
			Text = String.Format("{0} - {1}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(3));
			tbFolder.Text = Properties.Settings.Default.LastFolder;
			tbWildcard.Text = Properties.Settings.Default.LastWildcard;
			tbPrefix.Text = Properties.Settings.Default.PrefixNewFilename;

			string[] arrUnique = { "Date_time", "Date_Seqno", "Year-Month_Seqno" };
			cbUnique.Items.AddRange(arrUnique);
			cbUnique.Text = Properties.Settings.Default.UniqueNewFilename;
			string[] arrSupplement = { "None", "Camera", "Title", "Title or camera" };
			cbSupplement.Items.AddRange(arrSupplement);
			cbSupplement.Text = Properties.Settings.Default.SupplementNewFilename;

			btnSetNewNames.Enabled = false;

			dtCamera.Columns.Add("Cameramodel");
			dtCamera.Columns.Add("NameInFilename");

			if (File.Exists(XMLfile))
			{
				dtCamera.Rows.Clear();
				dtCamera.ReadXml(XMLfile);
			}

			dgvCamera.DataSource = dtCamera;
			dgvCamera.Sort(dgvCamera.Columns["tbcCameramodel"], System.ComponentModel.ListSortDirection.Ascending);

		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (tbFolder.Text.Length > 0 && Directory.Exists(tbFolder.Text))
			{
				Properties.Settings.Default.LastFolder = tbFolder.Text;
			}
			Properties.Settings.Default.LastWildcard = tbWildcard.Text;
			Properties.Settings.Default.PrefixNewFilename = tbPrefix.Text;
			Properties.Settings.Default.UniqueNewFilename = cbUnique.Text;
			Properties.Settings.Default.SupplementNewFilename = cbSupplement.Text;

			Properties.Settings.Default.Save();
			dtCamera.WriteXml(XMLfile, XmlWriteMode.WriteSchema);
		}

		private void btnBrowseFolder_Click(object sender, EventArgs e)
		{

			if (tbFolder.Text.Length > 0 && Directory.Exists(tbFolder.Text))
			{
				folderBrowserDialog.SelectedPath = tbFolder.Text;
			}

			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				tbFolder.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void filldgvFolderContent()
		{
			dgvFolderContent.Rows.Clear();
			btnSetNewNames.Enabled = false;
			btnExecuteRename.Text = "";
			btnExecuteRename.Enabled = false;

			if (tbFolder.Text.Length > 0 && Directory.Exists(tbFolder.Text))
			{

				if (tbFolder.Text.EndsWith(@"\") == false)
				{
					tbFolder.Text += @"\";
				}
				Image myImage;

				dgvFolderContent.Rows.Clear();
				string[] fileEntries = Directory.GetFiles(tbFolder.Text, tbWildcard.Text);
				foreach (string fileName in fileEntries)
				{
					string dateTaken = File.GetLastWriteTime(fileName).ToString("yyyy-MM-dd H:mm:ss");
					bool dateTakenAvail = false;
					string cameramodel = "";
					string phototitle = "";
					System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
					
					try
					{
						if (File.Exists(fileName) && (fileName.ToLower().Substring(fileName.Length - 4, 4) == ".jpg") || fileName.ToLower().Substring(fileName.Length - 5, 5) == ".jpeg")
						{
							myImage = Image.FromFile(fileName);

							var allPoprItem = myImage.PropertyItems;
							if (allPoprItem != null)
							{
								var pv = allPoprItem.FirstOrDefault(x => x.Id == 36867);
								if (pv != null)
								{
									dateTaken = r.Replace(Encoding.UTF8.GetString(pv.Value), "-", 2);
									dateTakenAvail = true;
								}

								pv = allPoprItem.FirstOrDefault(x => x.Id == 272);
								if (pv != null)
								{
									cameramodel = r.Replace(Encoding.UTF8.GetString(pv.Value), "-", 2).Trim('\0');
								}

								pv = allPoprItem.FirstOrDefault(x => x.Id == 270);
								if (pv != null)
								{
									phototitle = Encoding.UTF8.GetString(pv.Value).Trim('\0');
								}
							}
							myImage.Dispose();
						}
					}

					catch (Exception e)
					{
						dateTaken = "";
						dateTakenAvail = false;
						cameramodel = "";
						phototitle = "";
					}

					if (chkDateTaken.CheckState == CheckState.Unchecked || dateTakenAvail)
					{
						string cm = cameramodel;
						if (cameramodel.Length > 1)
						{
							bool present = false;
							foreach (DataRow dr in dtCamera.Rows)
							{
								if (dr[0] != null && dr[0].ToString() == cameramodel)
								{
									present = true;
									if (dr[1].ToString().Length > 0)
									{
										cm = dr[1].ToString();
									}
									break;
								}
							}
							if (present == false)
							{
								dtCamera.Rows.Add(cameramodel);
							}
						}

						dgvFolderContent.Rows.Add(fileName.Replace(tbFolder.Text, ""), dateTaken, cm, phototitle);
					}

					if ((dgvFolderContent.Rows.Count % 5) == 0) {
						lblNumberOfFiles.Text = String.Format("{0:d} files", dgvFolderContent.Rows.Count);
						Refresh();
					}
				}
			}

			if (dgvFolderContent.Rows.Count > 0)
			{
				btnSetNewNames.Enabled = true;
			}
			else
			{
				btnSetNewNames.Enabled = false;
			}
			lblNumberOfFiles.Text = String.Format("{0:d} files", dgvFolderContent.Rows.Count);
			Refresh();

		}

		private void btnSetNewNames_Click(object sender, EventArgs e)
		{
			fillNewNames();
		}
		private void fillNewNames()
		{
			string newName = tbPrefix.Text;
			string ext = "";
			int seqno = 0;
			DateTime prevdate = DateTime.Today.AddYears(-75);
			string et = "";
			string prev_supplement = "";
			int NumberOfNewNames = 0;

			btnExecuteRename.Enabled = false;
			btnExecuteRename.Text = "";

			dgvFolderContent.Sort(dgvFolderContent.Columns[1], ListSortDirection.Ascending);

			foreach (DataGridViewRow dgvr in dgvFolderContent.Rows) {
				newName = tbPrefix.Text;
				string fileName = dgvr.Cells[0].Value.ToString();

				if (cbSupplement.Text == "Title or camera")
				{
					if ((string)dgvr.Cells[3].Value != "")
					{
						et = dgvr.Cells[3].Value.ToString();
					}
					else
					{
						et = (string)dgvr.Cells[2].Value;
					}
				}
				else if (cbSupplement.Text == "Camera" && dgvr.Cells[2].Value.ToString().Length > 0)
				{
					et = dgvr.Cells[2].Value.ToString();

				}
				else if (cbSupplement.Text == "Title" && dgvr.Cells[3].Value.ToString().Length > 0)
				{
					et = dgvr.Cells[3].Value.ToString().Trim();
				}

				if (cbUnique.Text == "Date_time")
				{
					if (prevdate.ToString("yyyyMMdd_HHmmss") == DateTime.Parse((string)dgvr.Cells[1].Value).ToString("yyyyMMdd_HHmmss") && et == prev_supplement)
					{
						seqno += 1;
					}
					else
					{
						seqno = 1;
					}

					string hv = DateTime.Parse((string)dgvr.Cells[1].Value).ToString("yyyyMMdd_HHmmss");

					newName += hv;

					if (seqno > 1 || searchInFolderContent(dgvr.Cells[1].Value.ToString()) > 1)
					{
						newName += "_" + seqno.ToString("00");
					}
				}
				else if (cbUnique.Text == "Date_Seqno")
				{
					if (prevdate.ToString("yyyyMMdd") != DateTime.Parse((string)dgvr.Cells[1].Value).ToString("yyyyMMdd"))
					{
						seqno = 1;
					}
					else
					{
						seqno += 1;
					}

					newName += DateTime.Parse((string)dgvr.Cells[1].Value).ToString("yyyyMMdd") + "_" + seqno.ToString("0000");

				} 
				else if (cbUnique.Text == "Year-Month_Seqno")
				{
					if (prevdate.ToString("yyyyMM") != DateTime.Parse((string)dgvr.Cells[1].Value).ToString("yyyyMM"))
					{
						seqno = 1;
					}
					else
					{
						seqno += 1;
					}

					newName += DateTime.Parse((string)dgvr.Cells[1].Value).ToString("yyyy-MM") + "_" + seqno.ToString("00000");
				}

				ext = fileName.Substring(fileName.LastIndexOf("."), (fileName.Length - fileName.LastIndexOf(".")));
				if (et.Length > 0)
				{
					newName += "_" + et;
				}
				newName += ext.ToLower();

				prevdate = DateTime.Parse(dgvr.Cells[1].Value.ToString());
				prev_supplement = et;

				if (dgvr.Cells[0].Value.ToString() != newName)
				{
					dgvr.Cells[4].Value = newName;
					NumberOfNewNames += 1;
					if ((NumberOfNewNames % 5) == 0)
					{
						Refresh();
					}
				}
				else
				{
					dgvr.Cells[4].Value = "";
				}
			}

			if (NumberOfNewNames > 0)
			{
				btnExecuteRename.Enabled = true;
				btnExecuteRename.Text = String.Format("Rename {0:d} files", NumberOfNewNames);
			}
			else
			{
				MessageBox.Show("Ready, no files to rename.");
			}

		}

		private void executeRename()
		{
			foreach (DataGridViewRow dgvr in dgvFolderContent.Rows) {
				string newfn = dgvr.Cells[4].Value.ToString();
				if (newfn.Length > 0)
				{
					try
					{
						newfn = tbFolder.Text + newfn;
						string curfn = tbFolder.Text + dgvr.Cells[0].Value.ToString();
						if (File.Exists(curfn) && File.Exists(newfn) == false) {
							File.Move(curfn, newfn);
						}
					}
					catch (Exception e)
					{
						if (MessageBox.Show("Rename failed for " + newfn + ": " + e.Message, "Error", MessageBoxButtons.CancelTryContinue) == DialogResult.Cancel)
						{
							break;
						}
					}
				}
			}

			dgvFolderContent.Rows.Clear();
			btnSetNewNames.Enabled = false;
		}

		private void FillDataGridView_Click(object sender, EventArgs e)
		{
			if (tbFolder.Text.Length > 2)
			{
				filldgvFolderContent();
				fillNewNames();
			}
			else
			{
				MessageBox.Show("First select a folder.");
			}
		}

		private void btnExecuteRename_Click(object sender, EventArgs e)
		{
			executeRename();
		}

		private int searchInFolderContent(string searchValue) 
		{
			int rv = 0;

			foreach (DataGridViewRow r in dgvFolderContent.Rows)
			{
				if (r.Cells[1].Value.ToString() == searchValue)
				{
					rv++;
				}
			}

			return rv;
		}

		private void dgvFolderContent_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				string fn = tbFolder.Text + @"\" + dgvFolderContent.Rows[e.RowIndex].Cells[0].Value.ToString();
				if (File.Exists(fn)) {
					pbCurrentPhoto.Image = Image.FromFile(fn);
				} 
				else
				{
					pbCurrentPhoto.Image = null;
				}

			}
			else
			{
				pbCurrentPhoto.Image = null;
			}
		}
	}
}
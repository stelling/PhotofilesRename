namespace PhotofilesRename
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Panel panel;
			this.cbSupplement = new System.Windows.Forms.ComboBox();
			this.cbUnique = new System.Windows.Forms.ComboBox();
			this.lblSupllement = new System.Windows.Forms.Label();
			this.lblUniquePart = new System.Windows.Forms.Label();
			this.tbPrefix = new System.Windows.Forms.TextBox();
			this.lblPrefix = new System.Windows.Forms.Label();
			this.lblHeadNewName = new System.Windows.Forms.Label();
			this.lblFolder = new System.Windows.Forms.Label();
			this.tcMain = new System.Windows.Forms.TabControl();
			this.tpRename = new System.Windows.Forms.TabPage();
			this.btnExecuteRename = new System.Windows.Forms.Button();
			this.FillDataGridView = new System.Windows.Forms.Button();
			this.btnSetNewNames = new System.Windows.Forms.Button();
			this.chkDateTaken = new System.Windows.Forms.CheckBox();
			this.tbWildcard = new System.Windows.Forms.TextBox();
			this.lblWildcard = new System.Windows.Forms.Label();
			this.lblNumberOfFiles = new System.Windows.Forms.Label();
			this.dgvFolderContent = new System.Windows.Forms.DataGridView();
			this.tbcFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbcDateTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbcCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbcTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbcNewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnBrowseFolder = new System.Windows.Forms.Button();
			this.tbFolder = new System.Windows.Forms.TextBox();
			this.tpCameras = new System.Windows.Forms.TabPage();
			this.dgvCamera = new System.Windows.Forms.DataGridView();
			this.tbcCameramodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbcNameInFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			panel = new System.Windows.Forms.Panel();
			panel.SuspendLayout();
			this.tcMain.SuspendLayout();
			this.tpRename.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFolderContent)).BeginInit();
			this.tpCameras.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCamera)).BeginInit();
			this.SuspendLayout();
			// 
			// panel
			// 
			panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel.Controls.Add(this.cbSupplement);
			panel.Controls.Add(this.cbUnique);
			panel.Controls.Add(this.lblSupllement);
			panel.Controls.Add(this.lblUniquePart);
			panel.Controls.Add(this.tbPrefix);
			panel.Controls.Add(this.lblPrefix);
			panel.Controls.Add(this.lblHeadNewName);
			panel.Location = new System.Drawing.Point(1475, 55);
			panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			panel.Name = "panel";
			panel.Size = new System.Drawing.Size(281, 171);
			panel.TabIndex = 9;
			// 
			// cbSupplement
			// 
			this.cbSupplement.FormattingEnabled = true;
			this.cbSupplement.Location = new System.Drawing.Point(97, 127);
			this.cbSupplement.Name = "cbSupplement";
			this.cbSupplement.Size = new System.Drawing.Size(154, 24);
			this.cbSupplement.TabIndex = 6;
			// 
			// cbUnique
			// 
			this.cbUnique.FormattingEnabled = true;
			this.cbUnique.Location = new System.Drawing.Point(97, 89);
			this.cbUnique.Name = "cbUnique";
			this.cbUnique.Size = new System.Drawing.Size(154, 24);
			this.cbUnique.TabIndex = 5;
			// 
			// lblSupllement
			// 
			this.lblSupllement.Location = new System.Drawing.Point(9, 130);
			this.lblSupllement.Name = "lblSupllement";
			this.lblSupllement.Size = new System.Drawing.Size(82, 24);
			this.lblSupllement.TabIndex = 4;
			this.lblSupllement.Text = "Supplement";
			this.lblSupllement.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblUniquePart
			// 
			this.lblUniquePart.Location = new System.Drawing.Point(9, 92);
			this.lblUniquePart.Name = "lblUniquePart";
			this.lblUniquePart.Size = new System.Drawing.Size(82, 24);
			this.lblUniquePart.TabIndex = 3;
			this.lblUniquePart.Text = "Unique ID";
			this.lblUniquePart.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbPrefix
			// 
			this.tbPrefix.Location = new System.Drawing.Point(97, 53);
			this.tbPrefix.MaxLength = 8;
			this.tbPrefix.Name = "tbPrefix";
			this.tbPrefix.Size = new System.Drawing.Size(154, 23);
			this.tbPrefix.TabIndex = 2;
			// 
			// lblPrefix
			// 
			this.lblPrefix.Location = new System.Drawing.Point(9, 56);
			this.lblPrefix.Name = "lblPrefix";
			this.lblPrefix.Size = new System.Drawing.Size(82, 24);
			this.lblPrefix.TabIndex = 1;
			this.lblPrefix.Text = "Prefix";
			this.lblPrefix.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblHeadNewName
			// 
			this.lblHeadNewName.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblHeadNewName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblHeadNewName.Location = new System.Drawing.Point(0, 0);
			this.lblHeadNewName.Name = "lblHeadNewName";
			this.lblHeadNewName.Size = new System.Drawing.Size(279, 40);
			this.lblHeadNewName.TabIndex = 0;
			this.lblHeadNewName.Text = "New file name";
			this.lblHeadNewName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblFolder
			// 
			this.lblFolder.AutoSize = true;
			this.lblFolder.Location = new System.Drawing.Point(25, 21);
			this.lblFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFolder.Name = "lblFolder";
			this.lblFolder.Size = new System.Drawing.Size(43, 16);
			this.lblFolder.TabIndex = 0;
			this.lblFolder.Text = "Folder";
			this.lblFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tcMain
			// 
			this.tcMain.Controls.Add(this.tpRename);
			this.tcMain.Controls.Add(this.tpCameras);
			this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcMain.Location = new System.Drawing.Point(0, 0);
			this.tcMain.Margin = new System.Windows.Forms.Padding(2);
			this.tcMain.Name = "tcMain";
			this.tcMain.SelectedIndex = 0;
			this.tcMain.Size = new System.Drawing.Size(1776, 679);
			this.tcMain.TabIndex = 1;
			// 
			// tpRename
			// 
			this.tpRename.Controls.Add(this.btnExecuteRename);
			this.tpRename.Controls.Add(this.FillDataGridView);
			this.tpRename.Controls.Add(this.btnSetNewNames);
			this.tpRename.Controls.Add(panel);
			this.tpRename.Controls.Add(this.chkDateTaken);
			this.tpRename.Controls.Add(this.tbWildcard);
			this.tpRename.Controls.Add(this.lblWildcard);
			this.tpRename.Controls.Add(this.lblNumberOfFiles);
			this.tpRename.Controls.Add(this.dgvFolderContent);
			this.tpRename.Controls.Add(this.btnBrowseFolder);
			this.tpRename.Controls.Add(this.tbFolder);
			this.tpRename.Controls.Add(this.lblFolder);
			this.tpRename.Location = new System.Drawing.Point(4, 25);
			this.tpRename.Margin = new System.Windows.Forms.Padding(2);
			this.tpRename.Name = "tpRename";
			this.tpRename.Padding = new System.Windows.Forms.Padding(2);
			this.tpRename.Size = new System.Drawing.Size(1768, 650);
			this.tpRename.TabIndex = 0;
			this.tpRename.Text = "Rename files";
			this.tpRename.UseVisualStyleBackColor = true;
			// 
			// btnExecuteRename
			// 
			this.btnExecuteRename.Enabled = false;
			this.btnExecuteRename.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnExecuteRename.Location = new System.Drawing.Point(1477, 361);
			this.btnExecuteRename.Name = "btnExecuteRename";
			this.btnExecuteRename.Size = new System.Drawing.Size(279, 54);
			this.btnExecuteRename.TabIndex = 12;
			this.btnExecuteRename.UseVisualStyleBackColor = false;
			this.btnExecuteRename.Click += new System.EventHandler(this.btnExecuteRename_Click);
			// 
			// FillDataGridView
			// 
			this.FillDataGridView.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.FillDataGridView.Location = new System.Drawing.Point(1475, 241);
			this.FillDataGridView.Name = "FillDataGridView";
			this.FillDataGridView.Size = new System.Drawing.Size(279, 54);
			this.FillDataGridView.TabIndex = 11;
			this.FillDataGridView.Text = "Fill table";
			this.FillDataGridView.UseVisualStyleBackColor = true;
			this.FillDataGridView.Click += new System.EventHandler(this.FillDataGridView_Click);
			// 
			// btnSetNewNames
			// 
			this.btnSetNewNames.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSetNewNames.Location = new System.Drawing.Point(1475, 301);
			this.btnSetNewNames.Name = "btnSetNewNames";
			this.btnSetNewNames.Size = new System.Drawing.Size(279, 54);
			this.btnSetNewNames.TabIndex = 10;
			this.btnSetNewNames.Text = "Fill column \'New name\' in table";
			this.btnSetNewNames.UseVisualStyleBackColor = true;
			this.btnSetNewNames.Click += new System.EventHandler(this.btnSetNewNames_Click);
			// 
			// chkDateTaken
			// 
			this.chkDateTaken.AutoSize = true;
			this.chkDateTaken.Checked = true;
			this.chkDateTaken.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDateTaken.Location = new System.Drawing.Point(1092, 20);
			this.chkDateTaken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chkDateTaken.Name = "chkDateTaken";
			this.chkDateTaken.Size = new System.Drawing.Size(139, 20);
			this.chkDateTaken.TabIndex = 8;
			this.chkDateTaken.Text = "Date taken required";
			this.chkDateTaken.UseVisualStyleBackColor = true;
			// 
			// tbWildcard
			// 
			this.tbWildcard.Location = new System.Drawing.Point(965, 20);
			this.tbWildcard.Margin = new System.Windows.Forms.Padding(2);
			this.tbWildcard.Name = "tbWildcard";
			this.tbWildcard.Size = new System.Drawing.Size(122, 23);
			this.tbWildcard.TabIndex = 6;
			this.tbWildcard.Leave += new System.EventHandler(this.tbWildcard_Leave);
			// 
			// lblWildcard
			// 
			this.lblWildcard.AutoSize = true;
			this.lblWildcard.Location = new System.Drawing.Point(903, 21);
			this.lblWildcard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblWildcard.Name = "lblWildcard";
			this.lblWildcard.Size = new System.Drawing.Size(57, 16);
			this.lblWildcard.TabIndex = 5;
			this.lblWildcard.Text = "Wildcard";
			// 
			// lblNumberOfFiles
			// 
			this.lblNumberOfFiles.AutoSize = true;
			this.lblNumberOfFiles.Location = new System.Drawing.Point(1368, 21);
			this.lblNumberOfFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNumberOfFiles.Name = "lblNumberOfFiles";
			this.lblNumberOfFiles.Size = new System.Drawing.Size(0, 16);
			this.lblNumberOfFiles.TabIndex = 4;
			// 
			// dgvFolderContent
			// 
			this.dgvFolderContent.AllowUserToAddRows = false;
			this.dgvFolderContent.AllowUserToDeleteRows = false;
			this.dgvFolderContent.AllowUserToResizeRows = false;
			this.dgvFolderContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dgvFolderContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFolderContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcFilename,
            this.tbcDateTaken,
            this.tbcCamera,
            this.tbcTitle,
            this.tbcNewName});
			this.dgvFolderContent.Location = new System.Drawing.Point(25, 55);
			this.dgvFolderContent.Margin = new System.Windows.Forms.Padding(2);
			this.dgvFolderContent.MultiSelect = false;
			this.dgvFolderContent.Name = "dgvFolderContent";
			this.dgvFolderContent.RowHeadersWidth = 62;
			this.dgvFolderContent.RowTemplate.Height = 30;
			this.dgvFolderContent.Size = new System.Drawing.Size(1431, 593);
			this.dgvFolderContent.TabIndex = 3;
			// 
			// tbcFilename
			// 
			this.tbcFilename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.tbcFilename.HeaderText = "File name";
			this.tbcFilename.MinimumWidth = 200;
			this.tbcFilename.Name = "tbcFilename";
			this.tbcFilename.ReadOnly = true;
			this.tbcFilename.Width = 200;
			// 
			// tbcDateTaken
			// 
			this.tbcDateTaken.HeaderText = "Date taken";
			this.tbcDateTaken.MinimumWidth = 8;
			this.tbcDateTaken.Name = "tbcDateTaken";
			this.tbcDateTaken.ReadOnly = true;
			this.tbcDateTaken.Width = 140;
			// 
			// tbcCamera
			// 
			this.tbcCamera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.tbcCamera.HeaderText = "Camera";
			this.tbcCamera.MinimumWidth = 140;
			this.tbcCamera.Name = "tbcCamera";
			this.tbcCamera.ReadOnly = true;
			this.tbcCamera.Width = 140;
			// 
			// tbcTitle
			// 
			this.tbcTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.tbcTitle.HeaderText = "Title photo";
			this.tbcTitle.MinimumWidth = 140;
			this.tbcTitle.Name = "tbcTitle";
			this.tbcTitle.ReadOnly = true;
			this.tbcTitle.Width = 140;
			// 
			// tbcNewName
			// 
			this.tbcNewName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.tbcNewName.HeaderText = "New name";
			this.tbcNewName.MinimumWidth = 140;
			this.tbcNewName.Name = "tbcNewName";
			this.tbcNewName.ReadOnly = true;
			this.tbcNewName.Width = 140;
			// 
			// btnBrowseFolder
			// 
			this.btnBrowseFolder.Location = new System.Drawing.Point(785, 18);
			this.btnBrowseFolder.Margin = new System.Windows.Forms.Padding(2);
			this.btnBrowseFolder.Name = "btnBrowseFolder";
			this.btnBrowseFolder.Size = new System.Drawing.Size(114, 26);
			this.btnBrowseFolder.TabIndex = 2;
			this.btnBrowseFolder.Text = "Browse folder";
			this.btnBrowseFolder.UseVisualStyleBackColor = true;
			this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
			// 
			// tbFolder
			// 
			this.tbFolder.Location = new System.Drawing.Point(73, 20);
			this.tbFolder.Margin = new System.Windows.Forms.Padding(2);
			this.tbFolder.Name = "tbFolder";
			this.tbFolder.Size = new System.Drawing.Size(709, 23);
			this.tbFolder.TabIndex = 1;
			// 
			// tpCameras
			// 
			this.tpCameras.Controls.Add(this.dgvCamera);
			this.tpCameras.Location = new System.Drawing.Point(4, 24);
			this.tpCameras.Margin = new System.Windows.Forms.Padding(2);
			this.tpCameras.Name = "tpCameras";
			this.tpCameras.Padding = new System.Windows.Forms.Padding(2);
			this.tpCameras.Size = new System.Drawing.Size(1768, 651);
			this.tpCameras.TabIndex = 1;
			this.tpCameras.Text = "Camera\'s";
			this.tpCameras.UseVisualStyleBackColor = true;
			// 
			// dgvCamera
			// 
			this.dgvCamera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCamera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcCameramodel,
            this.tbcNameInFilename});
			this.dgvCamera.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCamera.Location = new System.Drawing.Point(2, 2);
			this.dgvCamera.Margin = new System.Windows.Forms.Padding(2);
			this.dgvCamera.Name = "dgvCamera";
			this.dgvCamera.RowHeadersWidth = 62;
			this.dgvCamera.RowTemplate.Height = 33;
			this.dgvCamera.Size = new System.Drawing.Size(1764, 647);
			this.dgvCamera.TabIndex = 0;
			// 
			// tbcCameramodel
			// 
			this.tbcCameramodel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.tbcCameramodel.DataPropertyName = "Cameramodel";
			this.tbcCameramodel.HeaderText = "Cameramodel";
			this.tbcCameramodel.MinimumWidth = 500;
			this.tbcCameramodel.Name = "tbcCameramodel";
			this.tbcCameramodel.Width = 500;
			// 
			// tbcNameInFilename
			// 
			this.tbcNameInFilename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.tbcNameInFilename.DataPropertyName = "NameInFilename";
			this.tbcNameInFilename.HeaderText = "Name in filename";
			this.tbcNameInFilename.MinimumWidth = 500;
			this.tbcNameInFilename.Name = "tbcNameInFilename";
			this.tbcNameInFilename.Width = 500;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1776, 679);
			this.Controls.Add(this.tcMain);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmMain";
			this.Text = "PhotofilesRename";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			panel.ResumeLayout(false);
			panel.PerformLayout();
			this.tcMain.ResumeLayout(false);
			this.tpRename.ResumeLayout(false);
			this.tpRename.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFolderContent)).EndInit();
			this.tpCameras.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCamera)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Label lblFolder;
		private TabControl tcMain;
		private TabPage tpRename;
		private TabPage tpCameras;
		private TextBox tbFolder;
		private Button btnBrowseFolder;
		private FolderBrowserDialog folderBrowserDialog;
		private DataGridView dgvFolderContent;
		private Label lblNumberOfFiles;
		private DataGridView dgvCamera;
		private DataGridViewTextBoxColumn tbcCameramodel;
		private DataGridViewTextBoxColumn tbcNameInFilename;
		private Label lblWildcard;
		private TextBox tbWildcard;
		private CheckBox chkDateTaken;
		private Label lblHeadNewName;
		private Label lblPrefix;
		private TextBox tbPrefix;
		private Label lblSupllement;
		private Label lblUniquePart;
		private ComboBox cbUnique;
		private ComboBox cbSupplement;
		private Button btnSetNewNames;
		private Button FillDataGridView;
		private Button btnExecuteRename;
		private DataGridViewTextBoxColumn tbcFilename;
		private DataGridViewTextBoxColumn tbcDateTaken;
		private DataGridViewTextBoxColumn tbcCamera;
		private DataGridViewTextBoxColumn tbcTitle;
		private DataGridViewTextBoxColumn tbcNewName;
	}
}
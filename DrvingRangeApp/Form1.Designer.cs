namespace DrvingRangeApp
{
    partial class MainPage
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
            gridRangeData = new DataGridView();
            lblTitle = new Label();
            btnAdd = new Button();
            btnFile = new Button();
            btnViewTrends = new Button();
            checkPW = new CheckBox();
            check9Iron = new CheckBox();
            check8Iron = new CheckBox();
            check7Iron = new CheckBox();
            check6Iron = new CheckBox();
            check5Iron = new CheckBox();
            checkDriver = new CheckBox();
            groupClubFilters = new GroupBox();
            groupFlightFilters = new GroupBox();
            checkpullHook = new CheckBox();
            checkHook = new CheckBox();
            checkPull = new CheckBox();
            checkFade = new CheckBox();
            checkStraight = new CheckBox();
            checkPushSlice = new CheckBox();
            checkSlice = new CheckBox();
            checkPush = new CheckBox();
            checkDraw = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)gridRangeData).BeginInit();
            groupClubFilters.SuspendLayout();
            groupFlightFilters.SuspendLayout();
            SuspendLayout();
            // 
            // gridRangeData
            // 
            gridRangeData.AllowUserToOrderColumns = true;
            gridRangeData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRangeData.Location = new Point(12, 49);
            gridRangeData.Name = "gridRangeData";
            gridRangeData.Size = new Size(776, 150);
            gridRangeData.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(334, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(136, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Driving Range Data View";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 214);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnFile
            // 
            btnFile.Location = new Point(12, 243);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(75, 23);
            btnFile.TabIndex = 3;
            btnFile.Text = "Create File";
            btnFile.UseVisualStyleBackColor = true;
            // 
            // btnViewTrends
            // 
            btnViewTrends.Location = new Point(12, 272);
            btnViewTrends.Name = "btnViewTrends";
            btnViewTrends.Size = new Size(75, 23);
            btnViewTrends.TabIndex = 4;
            btnViewTrends.Text = "View Trends";
            btnViewTrends.UseVisualStyleBackColor = true;
            // 
            // checkPW
            // 
            checkPW.AutoSize = true;
            checkPW.Location = new Point(6, 22);
            checkPW.Name = "checkPW";
            checkPW.Size = new Size(110, 19);
            checkPW.TabIndex = 5;
            checkPW.Text = "Pitching Wedge";
            checkPW.UseVisualStyleBackColor = true;
            // 
            // check9Iron
            // 
            check9Iron.AutoSize = true;
            check9Iron.Location = new Point(6, 47);
            check9Iron.Name = "check9Iron";
            check9Iron.Size = new Size(56, 19);
            check9Iron.TabIndex = 6;
            check9Iron.Text = "9 Iron";
            check9Iron.UseVisualStyleBackColor = true;
            // 
            // check8Iron
            // 
            check8Iron.AutoSize = true;
            check8Iron.Location = new Point(6, 72);
            check8Iron.Name = "check8Iron";
            check8Iron.Size = new Size(56, 19);
            check8Iron.TabIndex = 7;
            check8Iron.Text = "8 Iron";
            check8Iron.UseVisualStyleBackColor = true;
            // 
            // check7Iron
            // 
            check7Iron.AutoSize = true;
            check7Iron.Location = new Point(6, 98);
            check7Iron.Name = "check7Iron";
            check7Iron.Size = new Size(56, 19);
            check7Iron.TabIndex = 8;
            check7Iron.Text = "7 Iron";
            check7Iron.UseVisualStyleBackColor = true;
            // 
            // check6Iron
            // 
            check6Iron.AutoSize = true;
            check6Iron.Location = new Point(6, 123);
            check6Iron.Name = "check6Iron";
            check6Iron.Size = new Size(56, 19);
            check6Iron.TabIndex = 9;
            check6Iron.Text = "6 Iron";
            check6Iron.UseVisualStyleBackColor = true;
            // 
            // check5Iron
            // 
            check5Iron.AutoSize = true;
            check5Iron.Location = new Point(6, 148);
            check5Iron.Name = "check5Iron";
            check5Iron.Size = new Size(56, 19);
            check5Iron.TabIndex = 10;
            check5Iron.Text = "5 Iron";
            check5Iron.UseVisualStyleBackColor = true;
            // 
            // checkDriver
            // 
            checkDriver.AutoSize = true;
            checkDriver.Location = new Point(6, 173);
            checkDriver.Name = "checkDriver";
            checkDriver.Size = new Size(57, 19);
            checkDriver.TabIndex = 11;
            checkDriver.Text = "Driver";
            checkDriver.UseVisualStyleBackColor = true;
            // 
            // groupClubFilters
            // 
            groupClubFilters.Controls.Add(checkPW);
            groupClubFilters.Controls.Add(checkDriver);
            groupClubFilters.Controls.Add(check9Iron);
            groupClubFilters.Controls.Add(check5Iron);
            groupClubFilters.Controls.Add(check8Iron);
            groupClubFilters.Controls.Add(check6Iron);
            groupClubFilters.Controls.Add(check7Iron);
            groupClubFilters.Location = new Point(180, 214);
            groupClubFilters.Name = "groupClubFilters";
            groupClubFilters.Size = new Size(131, 202);
            groupClubFilters.TabIndex = 12;
            groupClubFilters.TabStop = false;
            groupClubFilters.Text = "Club Filters";
            // 
            // groupFlightFilters
            // 
            groupFlightFilters.Controls.Add(checkDraw);
            groupFlightFilters.Controls.Add(checkPush);
            groupFlightFilters.Controls.Add(checkSlice);
            groupFlightFilters.Controls.Add(checkPushSlice);
            groupFlightFilters.Controls.Add(checkStraight);
            groupFlightFilters.Controls.Add(checkFade);
            groupFlightFilters.Controls.Add(checkPull);
            groupFlightFilters.Controls.Add(checkHook);
            groupFlightFilters.Controls.Add(checkpullHook);
            groupFlightFilters.Location = new Point(361, 214);
            groupFlightFilters.Name = "groupFlightFilters";
            groupFlightFilters.Size = new Size(256, 202);
            groupFlightFilters.TabIndex = 14;
            groupFlightFilters.TabStop = false;
            groupFlightFilters.Text = "Ball Flight Filters";
            // 
            // checkpullHook
            // 
            checkpullHook.AutoSize = true;
            checkpullHook.Location = new Point(6, 22);
            checkpullHook.Name = "checkpullHook";
            checkpullHook.Size = new Size(78, 19);
            checkpullHook.TabIndex = 12;
            checkpullHook.Text = "Pull Hook";
            checkpullHook.UseVisualStyleBackColor = true;
            // 
            // checkHook
            // 
            checkHook.AutoSize = true;
            checkHook.Location = new Point(6, 47);
            checkHook.Name = "checkHook";
            checkHook.Size = new Size(55, 19);
            checkHook.TabIndex = 13;
            checkHook.Text = "Hook";
            checkHook.UseVisualStyleBackColor = true;
            // 
            // checkPull
            // 
            checkPull.AutoSize = true;
            checkPull.Location = new Point(6, 72);
            checkPull.Name = "checkPull";
            checkPull.Size = new Size(46, 19);
            checkPull.TabIndex = 14;
            checkPull.Text = "Pull";
            checkPull.UseVisualStyleBackColor = true;
            // 
            // checkFade
            // 
            checkFade.AutoSize = true;
            checkFade.Location = new Point(6, 97);
            checkFade.Name = "checkFade";
            checkFade.Size = new Size(51, 19);
            checkFade.TabIndex = 15;
            checkFade.Text = "Fade";
            checkFade.UseVisualStyleBackColor = true;
            // 
            // checkStraight
            // 
            checkStraight.AutoSize = true;
            checkStraight.Location = new Point(90, 22);
            checkStraight.Name = "checkStraight";
            checkStraight.Size = new Size(67, 19);
            checkStraight.TabIndex = 16;
            checkStraight.Text = "Straight";
            checkStraight.UseVisualStyleBackColor = true;
            // 
            // checkPushSlice
            // 
            checkPushSlice.AutoSize = true;
            checkPushSlice.Location = new Point(163, 22);
            checkPushSlice.Name = "checkPushSlice";
            checkPushSlice.Size = new Size(79, 19);
            checkPushSlice.TabIndex = 17;
            checkPushSlice.Text = "Push Slice";
            checkPushSlice.UseVisualStyleBackColor = true;
            // 
            // checkSlice
            // 
            checkSlice.AutoSize = true;
            checkSlice.Location = new Point(163, 47);
            checkSlice.Name = "checkSlice";
            checkSlice.Size = new Size(50, 19);
            checkSlice.TabIndex = 18;
            checkSlice.Text = "Slice";
            checkSlice.UseVisualStyleBackColor = true;
            // 
            // checkPush
            // 
            checkPush.AutoSize = true;
            checkPush.Location = new Point(163, 72);
            checkPush.Name = "checkPush";
            checkPush.Size = new Size(52, 19);
            checkPush.TabIndex = 19;
            checkPush.Text = "Push";
            checkPush.UseVisualStyleBackColor = true;
            // 
            // checkDraw
            // 
            checkDraw.AutoSize = true;
            checkDraw.Location = new Point(163, 97);
            checkDraw.Name = "checkDraw";
            checkDraw.Size = new Size(53, 19);
            checkDraw.TabIndex = 20;
            checkDraw.Text = "Draw";
            checkDraw.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupFlightFilters);
            Controls.Add(groupClubFilters);
            Controls.Add(btnViewTrends);
            Controls.Add(btnFile);
            Controls.Add(btnAdd);
            Controls.Add(lblTitle);
            Controls.Add(gridRangeData);
            Name = "MainPage";
            Text = "Driving Range Data";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)gridRangeData).EndInit();
            groupClubFilters.ResumeLayout(false);
            groupClubFilters.PerformLayout();
            groupFlightFilters.ResumeLayout(false);
            groupFlightFilters.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridRangeData;
        private Label lblTitle;
        private Button btnAdd;
        private Button btnFile;
        private Button btnViewTrends;
        private CheckBox checkPW;
        private CheckBox check9Iron;
        private CheckBox check8Iron;
        private CheckBox check7Iron;
        private CheckBox check6Iron;
        private CheckBox check5Iron;
        private CheckBox checkDriver;
        private GroupBox groupClubFilters;
        private GroupBox groupFlightFilters;
        private CheckBox checkpullHook;
        private CheckBox checkStraight;
        private CheckBox checkFade;
        private CheckBox checkPull;
        private CheckBox checkHook;
        private CheckBox checkDraw;
        private CheckBox checkPush;
        private CheckBox checkSlice;
        private CheckBox checkPushSlice;
    }
}

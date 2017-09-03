namespace RabiRibiMapViewer
{
    partial class MapViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMap = new System.Windows.Forms.TabPage();
            this.checkBoxCacheCommit = new System.Windows.Forms.CheckBox();
            this.buttonMapCommitChanges = new System.Windows.Forms.Button();
            this.listBoxMapLayers = new System.Windows.Forms.ListBox();
            this.checkBoxMapAutoCommit = new System.Windows.Forms.CheckBox();
            this.checkBoxMapLeftClickChange = new System.Windows.Forms.CheckBox();
            this.buttonMapLoadMemory = new System.Windows.Forms.Button();
            this.tableLayoutFullMap = new System.Windows.Forms.TableLayoutPanel();
            this.tabPageRoom = new System.Windows.Forms.TabPage();
            this.buttonRoomMoveDown = new System.Windows.Forms.Button();
            this.buttonRoomMoveRight = new System.Windows.Forms.Button();
            this.buttonRoomMoveUp = new System.Windows.Forms.Button();
            this.buttonRoomMoveLeft = new System.Windows.Forms.Button();
            this.buttonRoomReload = new System.Windows.Forms.Button();
            this.buttonRoomCommitChanges = new System.Windows.Forms.Button();
            this.checkBoxRoomAutoCommit = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxRoomLayerSpriteOrder = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRoomLayerMemoryOrder = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelRoom = new System.Windows.Forms.TableLayoutPanel();
            this.tabPageRoomGraphic = new System.Windows.Forms.TabPage();
            this.buttonRoomGraphicMoveDown = new System.Windows.Forms.Button();
            this.buttonRoomGraphicMoveRight = new System.Windows.Forms.Button();
            this.buttonRoomGraphicMoveUp = new System.Windows.Forms.Button();
            this.buttonRoomGraphicMoveLeft = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxRoomGraphicLayerSpriteOrder = new System.Windows.Forms.ListBox();
            this.checkBoxRightClickCopy = new System.Windows.Forms.CheckBox();
            this.tableLayoutRoomGraphicPanelPalette = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxRoomGraphicLayerMemoryOrder = new System.Windows.Forms.ListBox();
            this.buttonRoomGraphicSelectPalette = new System.Windows.Forms.Button();
            this.checkBoxRoomGraphicVertical = new System.Windows.Forms.CheckBox();
            this.checkBoxRoomGraphicHorizontal = new System.Windows.Forms.CheckBox();
            this.pictureBoxRoomGraphicSprite = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelRoomGraphic = new System.Windows.Forms.TableLayoutPanel();
            this.tabPageRoomCollision = new System.Windows.Forms.TabPage();
            this.buttonRoomCollisionMoveDown = new System.Windows.Forms.Button();
            this.buttonRoomCollisionMoveRight = new System.Windows.Forms.Button();
            this.buttonRoomCollisionMoveUp = new System.Windows.Forms.Button();
            this.buttonRoomCollisionMoveLeft = new System.Windows.Forms.Button();
            this.tableLayoutPanelRoomCollisionCollisions = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRoomCollision = new System.Windows.Forms.TableLayoutPanel();
            this.tabPageSave = new System.Windows.Forms.TabPage();
            this.buttonSaveMap = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonPickMap = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPageMap.SuspendLayout();
            this.tabPageRoom.SuspendLayout();
            this.tabPageRoomGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoomGraphicSprite)).BeginInit();
            this.tabPageRoomCollision.SuspendLayout();
            this.tabPageSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMap);
            this.tabControl1.Controls.Add(this.tabPageRoom);
            this.tabControl1.Controls.Add(this.tabPageRoomGraphic);
            this.tabControl1.Controls.Add(this.tabPageRoomCollision);
            this.tabControl1.Controls.Add(this.tabPageSave);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1260, 682);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageMap
            // 
            this.tabPageMap.Controls.Add(this.checkBoxCacheCommit);
            this.tabPageMap.Controls.Add(this.buttonMapCommitChanges);
            this.tabPageMap.Controls.Add(this.listBoxMapLayers);
            this.tabPageMap.Controls.Add(this.checkBoxMapAutoCommit);
            this.tabPageMap.Controls.Add(this.checkBoxMapLeftClickChange);
            this.tabPageMap.Controls.Add(this.buttonMapLoadMemory);
            this.tabPageMap.Controls.Add(this.tableLayoutFullMap);
            this.tabPageMap.Location = new System.Drawing.Point(4, 22);
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMap.Size = new System.Drawing.Size(1252, 656);
            this.tabPageMap.TabIndex = 0;
            this.tabPageMap.Text = "Map";
            this.tabPageMap.UseVisualStyleBackColor = true;
            // 
            // checkBoxCacheCommit
            // 
            this.checkBoxCacheCommit.AutoSize = true;
            this.checkBoxCacheCommit.Checked = true;
            this.checkBoxCacheCommit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCacheCommit.Location = new System.Drawing.Point(1063, 184);
            this.checkBoxCacheCommit.Name = "checkBoxCacheCommit";
            this.checkBoxCacheCommit.Size = new System.Drawing.Size(108, 30);
            this.checkBoxCacheCommit.TabIndex = 6;
            this.checkBoxCacheCommit.Text = "Commit Changes \r\nTo Cache";
            this.checkBoxCacheCommit.UseVisualStyleBackColor = true;
            // 
            // buttonMapCommitChanges
            // 
            this.buttonMapCommitChanges.Location = new System.Drawing.Point(1063, 83);
            this.buttonMapCommitChanges.Name = "buttonMapCommitChanges";
            this.buttonMapCommitChanges.Size = new System.Drawing.Size(96, 23);
            this.buttonMapCommitChanges.TabIndex = 5;
            this.buttonMapCommitChanges.Text = "Commit Changes";
            this.buttonMapCommitChanges.UseVisualStyleBackColor = true;
            this.buttonMapCommitChanges.Click += new System.EventHandler(this.buttonMapCommitChanges_Click);
            // 
            // listBoxMapLayers
            // 
            this.listBoxMapLayers.FormattingEnabled = true;
            this.listBoxMapLayers.Items.AddRange(new object[] {
            "Style",
            "Color",
            "Background"});
            this.listBoxMapLayers.Location = new System.Drawing.Point(1063, 34);
            this.listBoxMapLayers.Name = "listBoxMapLayers";
            this.listBoxMapLayers.Size = new System.Drawing.Size(96, 43);
            this.listBoxMapLayers.TabIndex = 4;
            this.listBoxMapLayers.SelectedIndexChanged += new System.EventHandler(this.listBoxMapLayers_SelectedIndexChanged);
            // 
            // checkBoxMapAutoCommit
            // 
            this.checkBoxMapAutoCommit.AutoSize = true;
            this.checkBoxMapAutoCommit.Location = new System.Drawing.Point(1063, 148);
            this.checkBoxMapAutoCommit.Name = "checkBoxMapAutoCommit";
            this.checkBoxMapAutoCommit.Size = new System.Drawing.Size(113, 30);
            this.checkBoxMapAutoCommit.TabIndex = 3;
            this.checkBoxMapAutoCommit.Text = "Auto Commit After \r\nLeaving Textbox";
            this.checkBoxMapAutoCommit.UseVisualStyleBackColor = true;
            // 
            // checkBoxMapLeftClickChange
            // 
            this.checkBoxMapLeftClickChange.AutoSize = true;
            this.checkBoxMapLeftClickChange.Checked = true;
            this.checkBoxMapLeftClickChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMapLeftClickChange.Location = new System.Drawing.Point(1063, 112);
            this.checkBoxMapLeftClickChange.Name = "checkBoxMapLeftClickChange";
            this.checkBoxMapLeftClickChange.Size = new System.Drawing.Size(99, 30);
            this.checkBoxMapLeftClickChange.TabIndex = 2;
            this.checkBoxMapLeftClickChange.Text = "Left Click\r\nChanges Room";
            this.checkBoxMapLeftClickChange.UseVisualStyleBackColor = true;
            // 
            // buttonMapLoadMemory
            // 
            this.buttonMapLoadMemory.Location = new System.Drawing.Point(1063, 5);
            this.buttonMapLoadMemory.Name = "buttonMapLoadMemory";
            this.buttonMapLoadMemory.Size = new System.Drawing.Size(96, 23);
            this.buttonMapLoadMemory.TabIndex = 1;
            this.buttonMapLoadMemory.Text = "Load Memory";
            this.buttonMapLoadMemory.UseVisualStyleBackColor = true;
            this.buttonMapLoadMemory.Click += new System.EventHandler(this.buttonMapLoadMemory_Click);
            // 
            // tableLayoutFullMap
            // 
            this.tableLayoutFullMap.ColumnCount = 25;
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutFullMap.Location = new System.Drawing.Point(7, 4);
            this.tableLayoutFullMap.Name = "tableLayoutFullMap";
            this.tableLayoutFullMap.RowCount = 18;
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutFullMap.Size = new System.Drawing.Size(1050, 600);
            this.tableLayoutFullMap.TabIndex = 0;
            this.tableLayoutFullMap.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutFullMap_CellPaint);
            // 
            // tabPageRoom
            // 
            this.tabPageRoom.Controls.Add(this.buttonRoomMoveDown);
            this.tabPageRoom.Controls.Add(this.buttonRoomMoveRight);
            this.tabPageRoom.Controls.Add(this.buttonRoomMoveUp);
            this.tabPageRoom.Controls.Add(this.buttonRoomMoveLeft);
            this.tabPageRoom.Controls.Add(this.buttonRoomReload);
            this.tabPageRoom.Controls.Add(this.buttonRoomCommitChanges);
            this.tabPageRoom.Controls.Add(this.checkBoxRoomAutoCommit);
            this.tabPageRoom.Controls.Add(this.label2);
            this.tabPageRoom.Controls.Add(this.listBoxRoomLayerSpriteOrder);
            this.tabPageRoom.Controls.Add(this.label1);
            this.tabPageRoom.Controls.Add(this.listBoxRoomLayerMemoryOrder);
            this.tabPageRoom.Controls.Add(this.tableLayoutPanelRoom);
            this.tabPageRoom.Location = new System.Drawing.Point(4, 22);
            this.tabPageRoom.Name = "tabPageRoom";
            this.tabPageRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoom.Size = new System.Drawing.Size(1252, 656);
            this.tabPageRoom.TabIndex = 1;
            this.tabPageRoom.Text = "Room";
            this.tabPageRoom.UseVisualStyleBackColor = true;
            // 
            // buttonRoomMoveDown
            // 
            this.buttonRoomMoveDown.Location = new System.Drawing.Point(888, 339);
            this.buttonRoomMoveDown.Name = "buttonRoomMoveDown";
            this.buttonRoomMoveDown.Size = new System.Drawing.Size(20, 20);
            this.buttonRoomMoveDown.TabIndex = 11;
            this.buttonRoomMoveDown.Text = "v";
            this.buttonRoomMoveDown.UseVisualStyleBackColor = true;
            this.buttonRoomMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonRoomMoveRight
            // 
            this.buttonRoomMoveRight.Location = new System.Drawing.Point(914, 313);
            this.buttonRoomMoveRight.Name = "buttonRoomMoveRight";
            this.buttonRoomMoveRight.Size = new System.Drawing.Size(20, 20);
            this.buttonRoomMoveRight.TabIndex = 10;
            this.buttonRoomMoveRight.Text = ">";
            this.buttonRoomMoveRight.UseVisualStyleBackColor = true;
            this.buttonRoomMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // buttonRoomMoveUp
            // 
            this.buttonRoomMoveUp.Location = new System.Drawing.Point(888, 287);
            this.buttonRoomMoveUp.Name = "buttonRoomMoveUp";
            this.buttonRoomMoveUp.Size = new System.Drawing.Size(20, 20);
            this.buttonRoomMoveUp.TabIndex = 9;
            this.buttonRoomMoveUp.Text = "ʌ";
            this.buttonRoomMoveUp.UseVisualStyleBackColor = true;
            this.buttonRoomMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonRoomMoveLeft
            // 
            this.buttonRoomMoveLeft.Location = new System.Drawing.Point(862, 313);
            this.buttonRoomMoveLeft.Name = "buttonRoomMoveLeft";
            this.buttonRoomMoveLeft.Size = new System.Drawing.Size(20, 20);
            this.buttonRoomMoveLeft.TabIndex = 8;
            this.buttonRoomMoveLeft.Text = "<";
            this.buttonRoomMoveLeft.UseVisualStyleBackColor = true;
            this.buttonRoomMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // buttonRoomReload
            // 
            this.buttonRoomReload.Location = new System.Drawing.Point(858, 207);
            this.buttonRoomReload.Name = "buttonRoomReload";
            this.buttonRoomReload.Size = new System.Drawing.Size(75, 23);
            this.buttonRoomReload.TabIndex = 7;
            this.buttonRoomReload.Text = "Reload";
            this.buttonRoomReload.UseVisualStyleBackColor = true;
            this.buttonRoomReload.Click += new System.EventHandler(this.buttonRoomReload_Click);
            // 
            // buttonRoomCommitChanges
            // 
            this.buttonRoomCommitChanges.Location = new System.Drawing.Point(858, 177);
            this.buttonRoomCommitChanges.Name = "buttonRoomCommitChanges";
            this.buttonRoomCommitChanges.Size = new System.Drawing.Size(75, 23);
            this.buttonRoomCommitChanges.TabIndex = 6;
            this.buttonRoomCommitChanges.Text = "Commit Changes";
            this.buttonRoomCommitChanges.UseVisualStyleBackColor = true;
            this.buttonRoomCommitChanges.Click += new System.EventHandler(this.buttonRoomCommitChanges_Click);
            // 
            // checkBoxRoomAutoCommit
            // 
            this.checkBoxRoomAutoCommit.AutoSize = true;
            this.checkBoxRoomAutoCommit.Location = new System.Drawing.Point(1025, 7);
            this.checkBoxRoomAutoCommit.Name = "checkBoxRoomAutoCommit";
            this.checkBoxRoomAutoCommit.Size = new System.Drawing.Size(110, 30);
            this.checkBoxRoomAutoCommit.TabIndex = 5;
            this.checkBoxRoomAutoCommit.Text = "Auto Commit After\r\nLeaving Textbox";
            this.checkBoxRoomAutoCommit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(940, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Layer\r\n(Sprite Order)";
            // 
            // listBoxRoomLayerSpriteOrder
            // 
            this.listBoxRoomLayerSpriteOrder.FormattingEnabled = true;
            this.listBoxRoomLayerSpriteOrder.Items.AddRange(new object[] {
            "Collision",
            "Events",
            "Items",
            "Sprite 0",
            "Sprite 3",
            "Sprite 4",
            "Sprite 1",
            "Sprite 5",
            "Sprite 6",
            "Sprite 2"});
            this.listBoxRoomLayerSpriteOrder.Location = new System.Drawing.Point(940, 36);
            this.listBoxRoomLayerSpriteOrder.Name = "listBoxRoomLayerSpriteOrder";
            this.listBoxRoomLayerSpriteOrder.Size = new System.Drawing.Size(79, 134);
            this.listBoxRoomLayerSpriteOrder.TabIndex = 3;
            this.listBoxRoomLayerSpriteOrder.SelectedIndexChanged += new System.EventHandler(this.listBoxRoomLayerSpriteOrder_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Layer\r\n(Memory Order)";
            // 
            // listBoxRoomLayerMemoryOrder
            // 
            this.listBoxRoomLayerMemoryOrder.FormattingEnabled = true;
            this.listBoxRoomLayerMemoryOrder.Items.AddRange(new object[] {
            "Collision",
            "Events",
            "Items",
            "Sprite 0",
            "Sprite 1",
            "Sprite 2",
            "Sprite 3",
            "Sprite 4",
            "Sprite 5",
            "Sprite 6"});
            this.listBoxRoomLayerMemoryOrder.Location = new System.Drawing.Point(855, 36);
            this.listBoxRoomLayerMemoryOrder.Name = "listBoxRoomLayerMemoryOrder";
            this.listBoxRoomLayerMemoryOrder.Size = new System.Drawing.Size(79, 134);
            this.listBoxRoomLayerMemoryOrder.TabIndex = 1;
            this.listBoxRoomLayerMemoryOrder.SelectedIndexChanged += new System.EventHandler(this.listBoxRoomLayerMemoryOrder_SelectedIndexChanged);
            // 
            // tableLayoutPanelRoom
            // 
            this.tableLayoutPanelRoom.ColumnCount = 20;
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRoom.Location = new System.Drawing.Point(9, 7);
            this.tableLayoutPanelRoom.Name = "tableLayoutPanelRoom";
            this.tableLayoutPanelRoom.RowCount = 12;
            this.tableLayoutPanelRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelRoom.Size = new System.Drawing.Size(840, 400);
            this.tableLayoutPanelRoom.TabIndex = 0;
            // 
            // tabPageRoomGraphic
            // 
            this.tabPageRoomGraphic.Controls.Add(this.buttonRoomGraphicMoveDown);
            this.tabPageRoomGraphic.Controls.Add(this.buttonRoomGraphicMoveRight);
            this.tabPageRoomGraphic.Controls.Add(this.buttonRoomGraphicMoveUp);
            this.tabPageRoomGraphic.Controls.Add(this.buttonRoomGraphicMoveLeft);
            this.tabPageRoomGraphic.Controls.Add(this.label5);
            this.tabPageRoomGraphic.Controls.Add(this.label3);
            this.tabPageRoomGraphic.Controls.Add(this.listBoxRoomGraphicLayerSpriteOrder);
            this.tabPageRoomGraphic.Controls.Add(this.checkBoxRightClickCopy);
            this.tabPageRoomGraphic.Controls.Add(this.tableLayoutRoomGraphicPanelPalette);
            this.tabPageRoomGraphic.Controls.Add(this.label4);
            this.tabPageRoomGraphic.Controls.Add(this.listBoxRoomGraphicLayerMemoryOrder);
            this.tabPageRoomGraphic.Controls.Add(this.buttonRoomGraphicSelectPalette);
            this.tabPageRoomGraphic.Controls.Add(this.checkBoxRoomGraphicVertical);
            this.tabPageRoomGraphic.Controls.Add(this.checkBoxRoomGraphicHorizontal);
            this.tabPageRoomGraphic.Controls.Add(this.pictureBoxRoomGraphicSprite);
            this.tabPageRoomGraphic.Controls.Add(this.tableLayoutPanelRoomGraphic);
            this.tabPageRoomGraphic.Location = new System.Drawing.Point(4, 22);
            this.tabPageRoomGraphic.Name = "tabPageRoomGraphic";
            this.tabPageRoomGraphic.Size = new System.Drawing.Size(1252, 656);
            this.tabPageRoomGraphic.TabIndex = 2;
            this.tabPageRoomGraphic.Text = "Room Graphic";
            this.tabPageRoomGraphic.UseVisualStyleBackColor = true;
            // 
            // buttonRoomGraphicMoveDown
            // 
            this.buttonRoomGraphicMoveDown.Location = new System.Drawing.Point(1004, 461);
            this.buttonRoomGraphicMoveDown.Name = "buttonRoomGraphicMoveDown";
            this.buttonRoomGraphicMoveDown.Size = new System.Drawing.Size(20, 20);
            this.buttonRoomGraphicMoveDown.TabIndex = 18;
            this.buttonRoomGraphicMoveDown.Text = "v";
            this.buttonRoomGraphicMoveDown.UseVisualStyleBackColor = true;
            this.buttonRoomGraphicMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonRoomGraphicMoveRight
            // 
            this.buttonRoomGraphicMoveRight.Location = new System.Drawing.Point(1030, 435);
            this.buttonRoomGraphicMoveRight.Name = "buttonRoomGraphicMoveRight";
            this.buttonRoomGraphicMoveRight.Size = new System.Drawing.Size(20, 20);
            this.buttonRoomGraphicMoveRight.TabIndex = 17;
            this.buttonRoomGraphicMoveRight.Text = ">";
            this.buttonRoomGraphicMoveRight.UseVisualStyleBackColor = true;
            this.buttonRoomGraphicMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // buttonRoomGraphicMoveUp
            // 
            this.buttonRoomGraphicMoveUp.Location = new System.Drawing.Point(1004, 409);
            this.buttonRoomGraphicMoveUp.Name = "buttonRoomGraphicMoveUp";
            this.buttonRoomGraphicMoveUp.Size = new System.Drawing.Size(20, 20);
            this.buttonRoomGraphicMoveUp.TabIndex = 16;
            this.buttonRoomGraphicMoveUp.Text = "ʌ";
            this.buttonRoomGraphicMoveUp.UseVisualStyleBackColor = true;
            this.buttonRoomGraphicMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonRoomGraphicMoveLeft
            // 
            this.buttonRoomGraphicMoveLeft.Location = new System.Drawing.Point(978, 435);
            this.buttonRoomGraphicMoveLeft.Name = "buttonRoomGraphicMoveLeft";
            this.buttonRoomGraphicMoveLeft.Size = new System.Drawing.Size(20, 20);
            this.buttonRoomGraphicMoveLeft.TabIndex = 15;
            this.buttonRoomGraphicMoveLeft.Text = "<";
            this.buttonRoomGraphicMoveLeft.UseVisualStyleBackColor = true;
            this.buttonRoomGraphicMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1034, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sprite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(976, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Memory";
            // 
            // listBoxRoomGraphicLayerSpriteOrder
            // 
            this.listBoxRoomGraphicLayerSpriteOrder.FormattingEnabled = true;
            this.listBoxRoomGraphicLayerSpriteOrder.Items.AddRange(new object[] {
            "Sprite 0",
            "Sprite 3",
            "Sprite 4",
            "Sprite 1",
            "Sprite 5",
            "Sprite 6",
            "Sprite 2"});
            this.listBoxRoomGraphicLayerSpriteOrder.Location = new System.Drawing.Point(1030, 194);
            this.listBoxRoomGraphicLayerSpriteOrder.Name = "listBoxRoomGraphicLayerSpriteOrder";
            this.listBoxRoomGraphicLayerSpriteOrder.Size = new System.Drawing.Size(50, 95);
            this.listBoxRoomGraphicLayerSpriteOrder.TabIndex = 12;
            this.listBoxRoomGraphicLayerSpriteOrder.SelectedIndexChanged += new System.EventHandler(this.listBoxRoomGraphicLayerSpriteOrder_SelectedIndexChanged);
            // 
            // checkBoxRightClickCopy
            // 
            this.checkBoxRightClickCopy.AutoSize = true;
            this.checkBoxRightClickCopy.Location = new System.Drawing.Point(977, 342);
            this.checkBoxRightClickCopy.Name = "checkBoxRightClickCopy";
            this.checkBoxRightClickCopy.Size = new System.Drawing.Size(107, 43);
            this.checkBoxRightClickCopy.TabIndex = 11;
            this.checkBoxRightClickCopy.Text = "Right Click Copy \r\nRoom Sprite to \r\nActive Palette";
            this.checkBoxRightClickCopy.UseVisualStyleBackColor = true;
            // 
            // tableLayoutRoomGraphicPanelPalette
            // 
            this.tableLayoutRoomGraphicPanelPalette.ColumnCount = 3;
            this.tableLayoutRoomGraphicPanelPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.Location = new System.Drawing.Point(1098, 3);
            this.tableLayoutRoomGraphicPanelPalette.Name = "tableLayoutRoomGraphicPanelPalette";
            this.tableLayoutRoomGraphicPanelPalette.RowCount = 13;
            this.tableLayoutRoomGraphicPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRoomGraphicPanelPalette.Size = new System.Drawing.Size(150, 650);
            this.tableLayoutRoomGraphicPanelPalette.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(994, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Layer Order";
            // 
            // listBoxRoomGraphicLayerMemoryOrder
            // 
            this.listBoxRoomGraphicLayerMemoryOrder.FormattingEnabled = true;
            this.listBoxRoomGraphicLayerMemoryOrder.Items.AddRange(new object[] {
            "Sprite 0",
            "Sprite 1",
            "Sprite 2",
            "Sprite 3",
            "Sprite 4",
            "Sprite 5",
            "Sprite 6"});
            this.listBoxRoomGraphicLayerMemoryOrder.Location = new System.Drawing.Point(974, 194);
            this.listBoxRoomGraphicLayerMemoryOrder.Name = "listBoxRoomGraphicLayerMemoryOrder";
            this.listBoxRoomGraphicLayerMemoryOrder.Size = new System.Drawing.Size(50, 95);
            this.listBoxRoomGraphicLayerMemoryOrder.TabIndex = 5;
            this.listBoxRoomGraphicLayerMemoryOrder.SelectedIndexChanged += new System.EventHandler(this.listBoxRoomGraphicLayer_SelectedIndexChanged);
            // 
            // buttonRoomGraphicSelectPalette
            // 
            this.buttonRoomGraphicSelectPalette.Location = new System.Drawing.Point(977, 312);
            this.buttonRoomGraphicSelectPalette.Name = "buttonRoomGraphicSelectPalette";
            this.buttonRoomGraphicSelectPalette.Size = new System.Drawing.Size(115, 23);
            this.buttonRoomGraphicSelectPalette.TabIndex = 4;
            this.buttonRoomGraphicSelectPalette.Text = "Select Sprite Palette";
            this.buttonRoomGraphicSelectPalette.UseVisualStyleBackColor = true;
            this.buttonRoomGraphicSelectPalette.Click += new System.EventHandler(this.buttonRoomGraphicFill_Click);
            // 
            // checkBoxRoomGraphicVertical
            // 
            this.checkBoxRoomGraphicVertical.AutoSize = true;
            this.checkBoxRoomGraphicVertical.Location = new System.Drawing.Point(974, 130);
            this.checkBoxRoomGraphicVertical.Name = "checkBoxRoomGraphicVertical";
            this.checkBoxRoomGraphicVertical.Size = new System.Drawing.Size(61, 17);
            this.checkBoxRoomGraphicVertical.TabIndex = 3;
            this.checkBoxRoomGraphicVertical.Text = "Vertical";
            this.checkBoxRoomGraphicVertical.UseVisualStyleBackColor = true;
            this.checkBoxRoomGraphicVertical.CheckedChanged += new System.EventHandler(this.checkBoxRoomGraphicVertical_CheckedChanged);
            // 
            // checkBoxRoomGraphicHorizontal
            // 
            this.checkBoxRoomGraphicHorizontal.AutoSize = true;
            this.checkBoxRoomGraphicHorizontal.Location = new System.Drawing.Point(974, 106);
            this.checkBoxRoomGraphicHorizontal.Name = "checkBoxRoomGraphicHorizontal";
            this.checkBoxRoomGraphicHorizontal.Size = new System.Drawing.Size(73, 17);
            this.checkBoxRoomGraphicHorizontal.TabIndex = 2;
            this.checkBoxRoomGraphicHorizontal.Text = "Horizontal";
            this.checkBoxRoomGraphicHorizontal.UseVisualStyleBackColor = true;
            this.checkBoxRoomGraphicHorizontal.CheckedChanged += new System.EventHandler(this.checkBoxRoomGraphicHorizontal_CheckedChanged);
            // 
            // pictureBoxRoomGraphicSprite
            // 
            this.pictureBoxRoomGraphicSprite.Location = new System.Drawing.Point(974, 3);
            this.pictureBoxRoomGraphicSprite.Name = "pictureBoxRoomGraphicSprite";
            this.pictureBoxRoomGraphicSprite.Size = new System.Drawing.Size(96, 96);
            this.pictureBoxRoomGraphicSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoomGraphicSprite.TabIndex = 1;
            this.pictureBoxRoomGraphicSprite.TabStop = false;
            // 
            // tableLayoutPanelRoomGraphic
            // 
            this.tableLayoutPanelRoomGraphic.ColumnCount = 20;
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomGraphic.Location = new System.Drawing.Point(8, 3);
            this.tableLayoutPanelRoomGraphic.Name = "tableLayoutPanelRoomGraphic";
            this.tableLayoutPanelRoomGraphic.RowCount = 12;
            this.tableLayoutPanelRoomGraphic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomGraphic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomGraphic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomGraphic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomGraphic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomGraphic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomGraphic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomGraphic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomGraphic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomGraphic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomGraphic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomGraphic.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomGraphic.Size = new System.Drawing.Size(960, 576);
            this.tableLayoutPanelRoomGraphic.TabIndex = 0;
            // 
            // tabPageRoomCollision
            // 
            this.tabPageRoomCollision.Controls.Add(this.buttonRoomCollisionMoveDown);
            this.tabPageRoomCollision.Controls.Add(this.buttonRoomCollisionMoveRight);
            this.tabPageRoomCollision.Controls.Add(this.buttonRoomCollisionMoveUp);
            this.tabPageRoomCollision.Controls.Add(this.buttonRoomCollisionMoveLeft);
            this.tabPageRoomCollision.Controls.Add(this.tableLayoutPanelRoomCollisionCollisions);
            this.tabPageRoomCollision.Controls.Add(this.tableLayoutPanelRoomCollision);
            this.tabPageRoomCollision.Location = new System.Drawing.Point(4, 22);
            this.tabPageRoomCollision.Name = "tabPageRoomCollision";
            this.tabPageRoomCollision.Size = new System.Drawing.Size(1252, 656);
            this.tabPageRoomCollision.TabIndex = 4;
            this.tabPageRoomCollision.Text = "Room Collision";
            this.tabPageRoomCollision.UseVisualStyleBackColor = true;
            // 
            // buttonRoomCollisionMoveDown
            // 
            this.buttonRoomCollisionMoveDown.Location = new System.Drawing.Point(1004, 461);
            this.buttonRoomCollisionMoveDown.Name = "buttonRoomCollisionMoveDown";
            this.buttonRoomCollisionMoveDown.Size = new System.Drawing.Size(20, 20);
            this.buttonRoomCollisionMoveDown.TabIndex = 22;
            this.buttonRoomCollisionMoveDown.Text = "v";
            this.buttonRoomCollisionMoveDown.UseVisualStyleBackColor = true;
            this.buttonRoomCollisionMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonRoomCollisionMoveRight
            // 
            this.buttonRoomCollisionMoveRight.Location = new System.Drawing.Point(1030, 435);
            this.buttonRoomCollisionMoveRight.Name = "buttonRoomCollisionMoveRight";
            this.buttonRoomCollisionMoveRight.Size = new System.Drawing.Size(20, 20);
            this.buttonRoomCollisionMoveRight.TabIndex = 21;
            this.buttonRoomCollisionMoveRight.Text = ">";
            this.buttonRoomCollisionMoveRight.UseVisualStyleBackColor = true;
            this.buttonRoomCollisionMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // buttonRoomCollisionMoveUp
            // 
            this.buttonRoomCollisionMoveUp.Location = new System.Drawing.Point(1004, 409);
            this.buttonRoomCollisionMoveUp.Name = "buttonRoomCollisionMoveUp";
            this.buttonRoomCollisionMoveUp.Size = new System.Drawing.Size(20, 20);
            this.buttonRoomCollisionMoveUp.TabIndex = 20;
            this.buttonRoomCollisionMoveUp.Text = "ʌ";
            this.buttonRoomCollisionMoveUp.UseVisualStyleBackColor = true;
            this.buttonRoomCollisionMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonRoomCollisionMoveLeft
            // 
            this.buttonRoomCollisionMoveLeft.Location = new System.Drawing.Point(978, 435);
            this.buttonRoomCollisionMoveLeft.Name = "buttonRoomCollisionMoveLeft";
            this.buttonRoomCollisionMoveLeft.Size = new System.Drawing.Size(20, 20);
            this.buttonRoomCollisionMoveLeft.TabIndex = 19;
            this.buttonRoomCollisionMoveLeft.Text = "<";
            this.buttonRoomCollisionMoveLeft.UseVisualStyleBackColor = true;
            this.buttonRoomCollisionMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // tableLayoutPanelRoomCollisionCollisions
            // 
            this.tableLayoutPanelRoomCollisionCollisions.ColumnCount = 4;
            this.tableLayoutPanelRoomCollisionCollisions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRoomCollisionCollisions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRoomCollisionCollisions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRoomCollisionCollisions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRoomCollisionCollisions.Location = new System.Drawing.Point(974, 3);
            this.tableLayoutPanelRoomCollisionCollisions.Name = "tableLayoutPanelRoomCollisionCollisions";
            this.tableLayoutPanelRoomCollisionCollisions.RowCount = 5;
            this.tableLayoutPanelRoomCollisionCollisions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelRoomCollisionCollisions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelRoomCollisionCollisions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelRoomCollisionCollisions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelRoomCollisionCollisions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelRoomCollisionCollisions.Size = new System.Drawing.Size(208, 260);
            this.tableLayoutPanelRoomCollisionCollisions.TabIndex = 1;
            this.tableLayoutPanelRoomCollisionCollisions.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanelRoomCollisionCollisions_CellPaint);
            // 
            // tableLayoutPanelRoomCollision
            // 
            this.tableLayoutPanelRoomCollision.ColumnCount = 20;
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRoomCollision.Location = new System.Drawing.Point(8, 3);
            this.tableLayoutPanelRoomCollision.Name = "tableLayoutPanelRoomCollision";
            this.tableLayoutPanelRoomCollision.RowCount = 12;
            this.tableLayoutPanelRoomCollision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomCollision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomCollision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomCollision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomCollision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomCollision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomCollision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomCollision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomCollision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomCollision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomCollision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomCollision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoomCollision.Size = new System.Drawing.Size(960, 576);
            this.tableLayoutPanelRoomCollision.TabIndex = 0;
            // 
            // tabPageSave
            // 
            this.tabPageSave.Controls.Add(this.buttonSaveMap);
            this.tabPageSave.Controls.Add(this.textBoxFilePath);
            this.tabPageSave.Controls.Add(this.buttonPickMap);
            this.tabPageSave.Location = new System.Drawing.Point(4, 22);
            this.tabPageSave.Name = "tabPageSave";
            this.tabPageSave.Size = new System.Drawing.Size(1252, 656);
            this.tabPageSave.TabIndex = 3;
            this.tabPageSave.Text = "Save";
            this.tabPageSave.UseVisualStyleBackColor = true;
            // 
            // buttonSaveMap
            // 
            this.buttonSaveMap.Location = new System.Drawing.Point(21, 84);
            this.buttonSaveMap.Name = "buttonSaveMap";
            this.buttonSaveMap.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveMap.TabIndex = 2;
            this.buttonSaveMap.Text = "Save .map";
            this.buttonSaveMap.UseVisualStyleBackColor = true;
            this.buttonSaveMap.Click += new System.EventHandler(this.buttonSaveMap_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Enabled = false;
            this.textBoxFilePath.Location = new System.Drawing.Point(21, 57);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(355, 20);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // buttonPickMap
            // 
            this.buttonPickMap.Location = new System.Drawing.Point(21, 27);
            this.buttonPickMap.Name = "buttonPickMap";
            this.buttonPickMap.Size = new System.Drawing.Size(75, 23);
            this.buttonPickMap.TabIndex = 0;
            this.buttonPickMap.Text = "Pick .map";
            this.buttonPickMap.UseVisualStyleBackColor = true;
            this.buttonPickMap.Click += new System.EventHandler(this.buttonPickMap_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MapViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 681);
            this.Controls.Add(this.tabControl1);
            this.Name = "MapViewerForm";
            this.Text = "RBRB Map Viewer";
            this.tabControl1.ResumeLayout(false);
            this.tabPageMap.ResumeLayout(false);
            this.tabPageMap.PerformLayout();
            this.tabPageRoom.ResumeLayout(false);
            this.tabPageRoom.PerformLayout();
            this.tabPageRoomGraphic.ResumeLayout(false);
            this.tabPageRoomGraphic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoomGraphicSprite)).EndInit();
            this.tabPageRoomCollision.ResumeLayout(false);
            this.tabPageSave.ResumeLayout(false);
            this.tabPageSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageRoom;
        private System.Windows.Forms.TabPage tabPageMap;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFullMap;
        private System.Windows.Forms.CheckBox checkBoxMapAutoCommit;
        private System.Windows.Forms.CheckBox checkBoxMapLeftClickChange;
        private System.Windows.Forms.Button buttonMapLoadMemory;
        private System.Windows.Forms.ListBox listBoxMapLayers;
        private System.Windows.Forms.Button buttonMapCommitChanges;
        private System.Windows.Forms.TabPage tabPageRoomGraphic;
        private System.Windows.Forms.TabPage tabPageSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxRoomLayerSpriteOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRoomLayerMemoryOrder;
        private System.Windows.Forms.CheckBox checkBoxRoomAutoCommit;
        private System.Windows.Forms.Button buttonRoomCommitChanges;
        private System.Windows.Forms.Button buttonPickMap;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonSaveMap;
        private System.Windows.Forms.ListBox listBoxRoomGraphicLayerMemoryOrder;
        private System.Windows.Forms.Button buttonRoomGraphicSelectPalette;
        private System.Windows.Forms.CheckBox checkBoxRoomGraphicVertical;
        private System.Windows.Forms.CheckBox checkBoxRoomGraphicHorizontal;
        private System.Windows.Forms.PictureBox pictureBoxRoomGraphicSprite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoomGraphic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutRoomGraphicPanelPalette;
        private System.Windows.Forms.TabPage tabPageRoomCollision;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoomCollision;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoomCollisionCollisions;
        private System.Windows.Forms.CheckBox checkBoxCacheCommit;
        private System.Windows.Forms.CheckBox checkBoxRightClickCopy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxRoomGraphicLayerSpriteOrder;
        private System.Windows.Forms.Button buttonRoomMoveLeft;
        private System.Windows.Forms.Button buttonRoomMoveUp;
        private System.Windows.Forms.Button buttonRoomMoveDown;
        private System.Windows.Forms.Button buttonRoomMoveRight;
        private System.Windows.Forms.Button buttonRoomGraphicMoveDown;
        private System.Windows.Forms.Button buttonRoomGraphicMoveRight;
        private System.Windows.Forms.Button buttonRoomGraphicMoveUp;
        private System.Windows.Forms.Button buttonRoomGraphicMoveLeft;
        private System.Windows.Forms.Button buttonRoomCollisionMoveDown;
        private System.Windows.Forms.Button buttonRoomCollisionMoveRight;
        private System.Windows.Forms.Button buttonRoomCollisionMoveUp;
        private System.Windows.Forms.Button buttonRoomCollisionMoveLeft;
        private System.Windows.Forms.Button buttonRoomReload;
    }
}


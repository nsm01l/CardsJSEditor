<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveOverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.終了EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstCards = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnQuestionRemove = New System.Windows.Forms.Button()
        Me.btnAnsClear = New System.Windows.Forms.Button()
        Me.txtAns = New System.Windows.Forms.TextBox()
        Me.btnQuestionAdd = New System.Windows.Forms.Button()
        Me.btnQuestionClear = New System.Windows.Forms.Button()
        Me.cmbQuestion = New System.Windows.Forms.ComboBox()
        Me.btnCommentClear = New System.Windows.Forms.Button()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnCardRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnCardDown = New System.Windows.Forms.Button()
        Me.btnCardUp = New System.Windows.Forms.Button()
        Me.radioCards = New System.Windows.Forms.RadioButton()
        Me.radioDummy = New System.Windows.Forms.RadioButton()
        Me.topTable = New System.Windows.Forms.TableLayoutPanel()
        Me.panelTopLeft = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelTopCenter = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelTopRight = New System.Windows.Forms.Panel()
        Me.outputType = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToUpPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToDownDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.lstCards, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.topTable.SuspendLayout()
        Me.panelTopLeft.SuspendLayout()
        Me.panelTopCenter.SuspendLayout()
        Me.panelTopRight.SuspendLayout()
        Me.outputType.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem, Me.ヘルプToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(489, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem
        '
        Me.ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenOToolStripMenuItem, Me.SaveOverToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1, Me.ToolStripMenuItem3, Me.ToolStripSeparator2, Me.終了EToolStripMenuItem})
        Me.ToolStripMenuItem.Name = "ToolStripMenuItem"
        Me.ToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripMenuItem.Text = "ファイル(&F)"
        '
        'OpenOToolStripMenuItem
        '
        Me.OpenOToolStripMenuItem.Name = "OpenOToolStripMenuItem"
        Me.OpenOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenOToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.OpenOToolStripMenuItem.Text = "開く(&O)"
        '
        'SaveOverToolStripMenuItem
        '
        Me.SaveOverToolStripMenuItem.Name = "SaveOverToolStripMenuItem"
        Me.SaveOverToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveOverToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.SaveOverToolStripMenuItem.Text = "保存(&S)"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.SaveAsToolStripMenuItem.Text = "別名で保存(&A)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(208, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripMenuItem1.Text = "インポート(&I)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripMenuItem3.Text = "エクスポート(&E)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(208, 6)
        '
        '終了EToolStripMenuItem
        '
        Me.終了EToolStripMenuItem.Name = "終了EToolStripMenuItem"
        Me.終了EToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.終了EToolStripMenuItem.Text = "終了(&E)"
        '
        'ヘルプToolStripMenuItem
        '
        Me.ヘルプToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ヘルプToolStripMenuItem1})
        Me.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem"
        Me.ヘルプToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ヘルプToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'ヘルプToolStripMenuItem1
        '
        Me.ヘルプToolStripMenuItem1.Name = "ヘルプToolStripMenuItem1"
        Me.ヘルプToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.ヘルプToolStripMenuItem1.Text = "ヘルプ"
        '
        'lstCards
        '
        Me.lstCards.AllowUserToAddRows = False
        Me.lstCards.AllowUserToDeleteRows = False
        Me.lstCards.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstCards.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.lstCards.Location = New System.Drawing.Point(32, 263)
        Me.lstCards.MultiSelect = False
        Me.lstCards.Name = "lstCards"
        Me.lstCards.RowTemplate.Height = 21
        Me.lstCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lstCards.Size = New System.Drawing.Size(457, 119)
        Me.lstCards.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.lstCards, "ダブルクリックするとその項目を編集できます")
        '
        'Column1
        '
        Me.Column1.HeaderText = "答え"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column2
        '
        Me.Column2.HeaderText = "問題文"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        Me.Column3.HeaderText = "解説"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(156, 203)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(215, 41)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "追加(&D)"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "項目を追加します" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ctrl+Shift+Enterでも追加できます")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "js"
        Me.SaveFileDialog1.Filter = "JavaScript ファイル (*.js)|*.js"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "js"
        Me.OpenFileDialog1.Filter = "JavaScript ファイル(*.js)|*.js"
        '
        'btnQuestionRemove
        '
        Me.btnQuestionRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuestionRemove.Location = New System.Drawing.Point(130, 111)
        Me.btnQuestionRemove.Name = "btnQuestionRemove"
        Me.btnQuestionRemove.Size = New System.Drawing.Size(24, 20)
        Me.btnQuestionRemove.TabIndex = 5
        Me.btnQuestionRemove.Text = "R"
        Me.ToolTip1.SetToolTip(Me.btnQuestionRemove, "選択した問題文を削除します")
        Me.btnQuestionRemove.UseVisualStyleBackColor = True
        '
        'btnAnsClear
        '
        Me.btnAnsClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnsClear.Location = New System.Drawing.Point(112, 45)
        Me.btnAnsClear.Name = "btnAnsClear"
        Me.btnAnsClear.Size = New System.Drawing.Size(24, 18)
        Me.btnAnsClear.TabIndex = 2
        Me.btnAnsClear.Text = "C"
        Me.ToolTip1.SetToolTip(Me.btnAnsClear, "答えの内容を空にします")
        Me.btnAnsClear.UseVisualStyleBackColor = True
        '
        'txtAns
        '
        Me.txtAns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAns.Location = New System.Drawing.Point(3, 20)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.Size = New System.Drawing.Size(133, 19)
        Me.txtAns.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtAns, "答えを入力します")
        '
        'btnQuestionAdd
        '
        Me.btnQuestionAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuestionAdd.Location = New System.Drawing.Point(130, 5)
        Me.btnQuestionAdd.Name = "btnQuestionAdd"
        Me.btnQuestionAdd.Size = New System.Drawing.Size(52, 33)
        Me.btnQuestionAdd.TabIndex = 2
        Me.btnQuestionAdd.Text = "追加(&A)"
        Me.ToolTip1.SetToolTip(Me.btnQuestionAdd, "問題文を追加します" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ctrl+Enterで追加できます")
        Me.btnQuestionAdd.UseVisualStyleBackColor = True
        '
        'btnQuestionClear
        '
        Me.btnQuestionClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuestionClear.Location = New System.Drawing.Point(130, 45)
        Me.btnQuestionClear.Name = "btnQuestionClear"
        Me.btnQuestionClear.Size = New System.Drawing.Size(24, 18)
        Me.btnQuestionClear.TabIndex = 3
        Me.btnQuestionClear.Text = "C"
        Me.ToolTip1.SetToolTip(Me.btnQuestionClear, "入力しした問題文を空にします")
        Me.btnQuestionClear.UseVisualStyleBackColor = True
        '
        'cmbQuestion
        '
        Me.cmbQuestion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbQuestion.FormattingEnabled = True
        Me.cmbQuestion.Location = New System.Drawing.Point(3, 20)
        Me.cmbQuestion.Name = "cmbQuestion"
        Me.cmbQuestion.Size = New System.Drawing.Size(121, 138)
        Me.cmbQuestion.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cmbQuestion, "問題文を入力します" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ctrl+Enterで追加できます")
        '
        'btnCommentClear
        '
        Me.btnCommentClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCommentClear.Location = New System.Drawing.Point(116, 80)
        Me.btnCommentClear.Name = "btnCommentClear"
        Me.btnCommentClear.Size = New System.Drawing.Size(24, 18)
        Me.btnCommentClear.TabIndex = 3
        Me.btnCommentClear.Text = "C"
        Me.ToolTip1.SetToolTip(Me.btnCommentClear, "入力した解説を空にします")
        Me.btnCommentClear.UseVisualStyleBackColor = True
        '
        'txtComment
        '
        Me.txtComment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComment.Location = New System.Drawing.Point(4, 20)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtComment.Size = New System.Drawing.Size(133, 54)
        Me.txtComment.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtComment, "解説を入力します")
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Location = New System.Drawing.Point(380, 210)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(44, 34)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "新規(&N)"
        Me.ToolTip1.SetToolTip(Me.btnNew, "新規追加状態にします")
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnCardRemove
        '
        Me.btnCardRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCardRemove.Location = New System.Drawing.Point(433, 210)
        Me.btnCardRemove.Name = "btnCardRemove"
        Me.btnCardRemove.Size = New System.Drawing.Size(44, 34)
        Me.btnCardRemove.TabIndex = 6
        Me.btnCardRemove.Text = "削除(&R)"
        Me.ToolTip1.SetToolTip(Me.btnCardRemove, "選択した項目を削除します")
        Me.btnCardRemove.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Location = New System.Drawing.Point(156, 203)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(215, 41)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "変更(&U)"
        Me.ToolTip1.SetToolTip(Me.btnUpdate, "項目を変更します" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ctrl+Shift+Enterでも変更できます")
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDown.Location = New System.Drawing.Point(130, 137)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(24, 20)
        Me.btnDown.TabIndex = 6
        Me.btnDown.Text = "↓"
        Me.ToolTip1.SetToolTip(Me.btnDown, "選択した問題文を下に移動します")
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUp.Location = New System.Drawing.Point(130, 87)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(24, 20)
        Me.btnUp.TabIndex = 4
        Me.btnUp.Text = "↑"
        Me.ToolTip1.SetToolTip(Me.btnUp, "選択した問題文を上に移動します")
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnCardDown
        '
        Me.btnCardDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCardDown.Location = New System.Drawing.Point(2, 348)
        Me.btnCardDown.Name = "btnCardDown"
        Me.btnCardDown.Size = New System.Drawing.Size(24, 20)
        Me.btnCardDown.TabIndex = 9
        Me.btnCardDown.Text = "↓"
        Me.ToolTip1.SetToolTip(Me.btnCardDown, "選択した項目を下に移動します")
        Me.btnCardDown.UseVisualStyleBackColor = True
        '
        'btnCardUp
        '
        Me.btnCardUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCardUp.Location = New System.Drawing.Point(2, 302)
        Me.btnCardUp.Name = "btnCardUp"
        Me.btnCardUp.Size = New System.Drawing.Size(24, 20)
        Me.btnCardUp.TabIndex = 8
        Me.btnCardUp.Text = "↑"
        Me.ToolTip1.SetToolTip(Me.btnCardUp, "選択した項目を上に移動します")
        Me.btnCardUp.UseVisualStyleBackColor = True
        '
        'radioCards
        '
        Me.radioCards.AutoSize = True
        Me.radioCards.Checked = True
        Me.radioCards.Location = New System.Drawing.Point(7, 21)
        Me.radioCards.Name = "radioCards"
        Me.radioCards.Size = New System.Drawing.Size(51, 16)
        Me.radioCards.TabIndex = 0
        Me.radioCards.TabStop = True
        Me.radioCards.Text = "cards"
        Me.ToolTip1.SetToolTip(Me.radioCards, "cards.js を出力")
        Me.radioCards.UseVisualStyleBackColor = True
        '
        'radioDummy
        '
        Me.radioDummy.AutoSize = True
        Me.radioDummy.Location = New System.Drawing.Point(69, 21)
        Me.radioDummy.Name = "radioDummy"
        Me.radioDummy.Size = New System.Drawing.Size(59, 16)
        Me.radioDummy.TabIndex = 1
        Me.radioDummy.Text = "dummy"
        Me.ToolTip1.SetToolTip(Me.radioDummy, "dummy.js を出力")
        Me.radioDummy.UseVisualStyleBackColor = True
        '
        'topTable
        '
        Me.topTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.topTable.ColumnCount = 3
        Me.topTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.topTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.topTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.topTable.Controls.Add(Me.panelTopLeft, 0, 0)
        Me.topTable.Controls.Add(Me.panelTopCenter, 1, 0)
        Me.topTable.Controls.Add(Me.panelTopRight, 2, 0)
        Me.topTable.Location = New System.Drawing.Point(5, 27)
        Me.topTable.Name = "topTable"
        Me.topTable.RowCount = 1
        Me.topTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.topTable.Size = New System.Drawing.Size(484, 166)
        Me.topTable.TabIndex = 1
        '
        'panelTopLeft
        '
        Me.panelTopLeft.Controls.Add(Me.btnAnsClear)
        Me.panelTopLeft.Controls.Add(Me.txtAns)
        Me.panelTopLeft.Controls.Add(Me.Label1)
        Me.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTopLeft.Location = New System.Drawing.Point(3, 3)
        Me.panelTopLeft.Name = "panelTopLeft"
        Me.panelTopLeft.Size = New System.Drawing.Size(139, 160)
        Me.panelTopLeft.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "答え(&S)"
        '
        'panelTopCenter
        '
        Me.panelTopCenter.Controls.Add(Me.btnQuestionRemove)
        Me.panelTopCenter.Controls.Add(Me.btnQuestionAdd)
        Me.panelTopCenter.Controls.Add(Me.btnQuestionClear)
        Me.panelTopCenter.Controls.Add(Me.btnDown)
        Me.panelTopCenter.Controls.Add(Me.btnUp)
        Me.panelTopCenter.Controls.Add(Me.cmbQuestion)
        Me.panelTopCenter.Controls.Add(Me.Label2)
        Me.panelTopCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTopCenter.Location = New System.Drawing.Point(148, 3)
        Me.panelTopCenter.Name = "panelTopCenter"
        Me.panelTopCenter.Size = New System.Drawing.Size(187, 160)
        Me.panelTopCenter.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "問題文(&Q)"
        '
        'panelTopRight
        '
        Me.panelTopRight.Controls.Add(Me.outputType)
        Me.panelTopRight.Controls.Add(Me.Label4)
        Me.panelTopRight.Controls.Add(Me.btnCommentClear)
        Me.panelTopRight.Controls.Add(Me.txtComment)
        Me.panelTopRight.Controls.Add(Me.Label3)
        Me.panelTopRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTopRight.Location = New System.Drawing.Point(341, 3)
        Me.panelTopRight.Name = "panelTopRight"
        Me.panelTopRight.Size = New System.Drawing.Size(140, 160)
        Me.panelTopRight.TabIndex = 2
        '
        'outputType
        '
        Me.outputType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.outputType.Controls.Add(Me.radioDummy)
        Me.outputType.Controls.Add(Me.radioCards)
        Me.outputType.Location = New System.Drawing.Point(3, 111)
        Me.outputType.Name = "outputType"
        Me.outputType.Size = New System.Drawing.Size(134, 45)
        Me.outputType.TabIndex = 4
        Me.outputType.TabStop = False
        Me.outputType.Text = "出力形式"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "* 省略可能です" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* 改行禁止です"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "解説*(&C)"
        '
        'lblMsg
        '
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMsg.Location = New System.Drawing.Point(8, 203)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(139, 41)
        Me.lblMsg.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateUToolStripMenuItem, Me.RemoveRToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ToolStripSeparator1, Me.ToUpPToolStripMenuItem, Me.ToDownDToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(111, 120)
        '
        'UpdateUToolStripMenuItem
        '
        Me.UpdateUToolStripMenuItem.Name = "UpdateUToolStripMenuItem"
        Me.UpdateUToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.UpdateUToolStripMenuItem.Text = "変更(&U)"
        '
        'RemoveRToolStripMenuItem
        '
        Me.RemoveRToolStripMenuItem.Name = "RemoveRToolStripMenuItem"
        Me.RemoveRToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.RemoveRToolStripMenuItem.Text = "削除(&R)"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ClearToolStripMenuItem.Text = "解除(&C)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(107, 6)
        '
        'ToUpPToolStripMenuItem
        '
        Me.ToUpPToolStripMenuItem.Name = "ToUpPToolStripMenuItem"
        Me.ToUpPToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ToUpPToolStripMenuItem.Text = "上へ(&P)"
        '
        'ToDownDToolStripMenuItem
        '
        Me.ToDownDToolStripMenuItem.Name = "ToDownDToolStripMenuItem"
        Me.ToDownDToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ToDownDToolStripMenuItem.Text = "下へ(&D)"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "CSV ファイル (*.csv)|*.csv|すべてのファイル (*.*)|*.*"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 384)
        Me.Controls.Add(Me.btnCardDown)
        Me.Controls.Add(Me.btnCardUp)
        Me.Controls.Add(Me.btnCardRemove)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.topTable)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstCards)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "CardsJSEditor 1.4"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.lstCards, System.ComponentModel.ISupportInitialize).EndInit()
        Me.topTable.ResumeLayout(False)
        Me.panelTopLeft.ResumeLayout(False)
        Me.panelTopLeft.PerformLayout()
        Me.panelTopCenter.ResumeLayout(False)
        Me.panelTopCenter.PerformLayout()
        Me.panelTopRight.ResumeLayout(False)
        Me.panelTopRight.PerformLayout()
        Me.outputType.ResumeLayout(False)
        Me.outputType.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveOverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 終了EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstCards As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents topTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panelTopLeft As System.Windows.Forms.Panel
    Friend WithEvents btnQuestionRemove As System.Windows.Forms.Button
    Friend WithEvents btnAnsClear As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents txtAns As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelTopCenter As System.Windows.Forms.Panel
    Friend WithEvents btnQuestionAdd As System.Windows.Forms.Button
    Friend WithEvents btnQuestionClear As System.Windows.Forms.Button
    Friend WithEvents cmbQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panelTopRight As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCommentClear As System.Windows.Forms.Button
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ヘルプToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ヘルプToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnCardRemove As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UpdateUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCardDown As System.Windows.Forms.Button
    Friend WithEvents btnCardUp As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToUpPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToDownDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents outputType As System.Windows.Forms.GroupBox
    Friend WithEvents radioDummy As System.Windows.Forms.RadioButton
    Friend WithEvents radioCards As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog

End Class

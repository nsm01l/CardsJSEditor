Public Class Form1

    Private openedFilePath As String = ""   ' 編集中のファイルパス
    Private changedFlag As Boolean = False  ' 編集フラグ

    ''' <summary>
    ''' Card のクラス
    ''' </summary>
    Private Class Card
        Dim answer As String = ""
        Dim questions As String = ""
        Dim comment As String = ""

        Public Sub New(ByVal answer As String, ByVal questions As String)
            Me.answer = answer
            Me.questions = questions
        End Sub

        Public Sub New(ByVal answer As String, ByVal questions As String, ByVal comment As String)
            Me.New(answer, questions)
            Me.comment = comment
        End Sub

        Public Function getAnswer() As String
            Return answer
        End Function

        Public Function getQuestions() As String
            Return questions
        End Function

        Public Function getComment() As String
            Return comment
        End Function
    End Class

    ''' <summary>
    ''' 実行時
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' 表示、非表示
        btnUpdate.Visible = False
    End Sub

    ''' <summary>
    ''' ×ボタンを押した
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (changedFlag) Then
            If (MessageBox.Show("このファイルは編集中です。" & vbCrLf & _
                                "保存せずに終了しますか?", "CardsJSEditor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
                e.Cancel = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' 追加ボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim answer As String = txtAns.Text.Trim()
        Dim question As String = encodeQuestions()
        Dim comment As String = txtComment.Text.Trim()

        ' 解説が空でも追加
        If (answer.Length <> 0 And question.Length <> 0) Then
            If (comment.Length > 0) Then
                lstCards.Rows.Add("""" & answer & """", question, """" & comment & """")
            Else
                lstCards.Rows.Add("""" & answer & """", question, "")
            End If

            ' 初期化
            txtAns.Text = ""
            cmbQuestion.Items.Clear()
            cmbQuestion.Text = ""
            txtComment.Text = ""

            lstCards.Rows(lstCards.Rows.Count - 1).Cells(0).Selected = True
            lstCards.ClearSelection()

            ' メッセージ
            lblMsg.Text = """" & answer & """ を追加しました"

            ' フォーカスを付ける
            txtAns.Focus()

            changedFlag = True
        Else
            If (answer.Length = 0) Then
                lblMsg.Text = "答えが記入されていません"
            ElseIf (question.Length = 0) Then
                lblMsg.Text = "問題文が登録されていません"
            End If
        End If
    End Sub

    ''' <summary>
    ''' 変更ボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Dim answer As String = txtAns.Text.Trim()
        Dim question As String = encodeQuestions()
        Dim comment As String = txtComment.Text.Trim()

        Dim idx As Integer = lstCards.CurrentRow.Index

        ' 解説が空でも追加
        If (answer.Length <> 0 And question.Length <> 0) Then
            If (comment.Length > 0) Then
                lstCards.Rows(idx).SetValues("""" & answer & """", question, """" & comment & """")
            Else
                lstCards.Rows(idx).SetValues("""" & answer & """", question, "")
            End If

            ' 初期化
            txtAns.Text = ""
            cmbQuestion.Items.Clear()
            cmbQuestion.Text = ""
            txtComment.Text = ""

            lstCards.ClearSelection()

            ' 表示、非表示
            btnAdd.Visible = True
            btnUpdate.Visible = False

            ' メッセージ
            lblMsg.Text = """" & answer & """ を変更しました"

            ' フォーカスを付ける
            txtAns.Focus()

            changedFlag = True
        Else
            If (answer.Length = 0) Then
                lblMsg.Text = "答えが記入されていません"
            ElseIf (question.Length = 0) Then
                lblMsg.Text = "問題文が登録されていません"
            End If
        End If
    End Sub

    ''' <summary>
    ''' 選択したデータを削除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCardRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnCardRemove.Click
        ' データがない
        If lstCards.RowCount < 1 Then
            Exit Sub
        End If

        Dim idx As Integer = lstCards.CurrentRow.Index
        If (idx < 0 Or lstCards.SelectedRows.Count < 1) Then
            lblMsg.Text = "削除したいデータが選択されていません"
            Exit Sub
        Else
            lblMsg.Text = lstCards.Rows(idx).Cells(0).Value.ToString() & " を削除しました"
            lstCards.Rows.RemoveAt(idx)
            changedFlag = True
        End If
    End Sub

    ''' <summary>
    ''' 初期状態に戻す
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        lstCards.ClearSelection()
        txtAns.Text = ""
        cmbQuestion.Items.Clear()
        txtComment.Text = ""

        btnUpdate.Visible = False
        btnAdd.Visible = True
    End Sub

    ''' <summary>
    ''' lstCards のリサイズ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lstCards_SizeChanged(sender As System.Object, e As System.EventArgs) Handles lstCards.SizeChanged
        With lstCards
            Dim w As Integer = Convert.ToInt32((.Size.Width - .RowHeadersWidth) * 0.32)
            lstCards.Columns(0).Width = w
            lstCards.Columns(1).Width = w
            lstCards.Columns(2).Width = w
        End With
    End Sub


    ' ===================================
    '   メニュー
    ' ===================================

    ''' <summary>
    ''' 上書き保存
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveOverToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveOverToolStripMenuItem.Click
        ' 新規作成かチェック
        If (openedFilePath.Length = 0) Then
            SaveAsToolStripMenuItem_Click(sender, e)    ' 名前を付けて保存
        Else
            outputJS(openedFilePath)
        End If
    End Sub

    ''' <summary>
    ''' 名前を付けて保存
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveAsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        ' 新規作成ならダイアログ表示
        If (SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            outputJS(SaveFileDialog1.FileName)
        End If
    End Sub

    ''' <summary>
    ''' ファイルを開く
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OpenOToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenOToolStripMenuItem.Click
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            inputJS(OpenFileDialog1.FileName)

            ' 保存用にファイル名を指定
            SaveFileDialog1.FileName = OpenFileDialog1.FileName
        End If
    End Sub

    ''' <summary>
    ''' インポート
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If (OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            importCSV(OpenFileDialog2.FileName)
        End If
    End Sub

    ''' <summary>
    ''' エクスポート
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        MessageBox.Show("まだ使えません", "CardsJSEditor")
    End Sub

    ''' <summary>
    ''' 終了
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub 終了EToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 終了EToolStripMenuItem.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' ヘルプが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ヘルプToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ヘルプToolStripMenuItem1.Click
        MessageBox.Show("CardsJSEditor はあまり賢くありません。" & vbCrLf & vbCrLf & _
                        "ファイルを直接編集するときは 1 行に 1 つのデータを入れるようにしてください。" & vbCrLf & vbCrLf & _
                        "ファイルを直接編集するとき文字列は "" で囲んでください、' ではダメです。", "CardsJSEditor", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub



    ' ===================================
    '   問題文
    ' ===================================

    ''' <summary>
    ''' btnQuestionAdd で問題文を追加
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnQuestionAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnQuestionAdd.Click
        With cmbQuestion
            Dim str As String = .Text.Trim()

            ' 空なら追加しない
            If (str.Length = 0) Then
                Exit Sub
            End If

            Dim s As Integer = .Items.Count

            ' 線形探索
            Dim i As Integer
            For i = 0 To s - 1 Step 1
                If (.Items.Item(i) = str) Then
                    Exit For
                End If
            Next i

            If (i = s) Then
                ' 追加した
                .Items.Add(str)
                .Text = ""
                .Focus()
            Else
                ' 存在するので選択
                .SelectedIndex = i
            End If
        End With
    End Sub

    ''' <summary>
    ''' cmbQuestion のショートカットキー
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmbQuestion_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbQuestion.KeyUp
        If (e.Control And e.Shift And e.KeyCode = Keys.Enter) Then
            ' Ctrl + Shift + Enter で項目を追加する
            If (btnAdd.Visible) Then
                btnAdd_Click(sender, e)
            ElseIf (btnUpdate.Visible) Then
                btnUpdate_Click(sender, e)
            End If
        ElseIf (e.Control And e.KeyCode = Keys.Enter) Then
            ' Ctrl+Enter で問題文を追加する
            btnQuestionAdd_Click(sender, e)
        End If
    End Sub

    ''' <summary>
    ''' 問題文の選択項目が変わったら入力状態にする
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmbQuestion_SelectedIndexChanged(sender As Object, e As System.EventArgs)
        With cmbQuestion
            .Text = .SelectedItem
        End With
    End Sub

    ''' <summary>
    ''' 入力中の問題文をクリアーする
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnQuestionClear_Click(sender As System.Object, e As System.EventArgs) Handles btnQuestionClear.Click
        With cmbQuestion
            .SelectedIndex = -1
            .Text = ""
        End With
    End Sub

    ''' <summary>
    ''' 選択した問題文を消す
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnQuestionRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnQuestionRemove.Click
        With cmbQuestion
            If (.SelectedIndex >= 0) Then
                .Items.RemoveAt(.SelectedIndex)
            End If
        End With
    End Sub

    ''' <summary>
    ''' 下ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDown_Click(sender As System.Object, e As System.EventArgs) Handles btnDown.Click
        Dim str() As String = cmbQuestionItemsToArray()
        Dim idx As Integer = cmbQuestion.SelectedIndex
        Dim s As Integer = str.Length

        If (idx < 0) Then
            Exit Sub
        ElseIf (idx = s - 1) Then
            Dim t As String = str(s - 1)
            For i As Integer = s - 2 To 0 Step -1
                str(i + 1) = str(i)
            Next i
            str(0) = t
        Else
            Dim t As String = str(idx)
            str(idx) = str(idx + 1)
            str(idx + 1) = t
        End If

        ' 再描画
        cmbQuestion.Items.Clear()
        cmbQuestion.Items.AddRange(str)

        ' 再選択
        If (idx = s - 1) Then
            cmbQuestion.SelectedIndex = 0
        Else
            cmbQuestion.SelectedIndex = idx + 1
        End If
    End Sub

    ''' <summary>
    ''' 上ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnUp_Click(sender As System.Object, e As System.EventArgs) Handles btnUp.Click
        Dim str() As String = cmbQuestionItemsToArray()
        Dim idx As Integer = cmbQuestion.SelectedIndex

        If (idx < 0) Then
            Exit Sub
        ElseIf (idx > 0) Then
            Dim t As String = str(idx - 1)
            str(idx - 1) = str(idx)
            str(idx) = t
        Else
            Dim t As String = str(0)
            Dim s As Integer = str.Length
            For i As Integer = 1 To s - 1 Step 1
                str(i - 1) = str(i)
            Next i
            str(s - 1) = t
        End If

        ' 再描画
        cmbQuestion.Items.Clear()
        cmbQuestion.Items.AddRange(str)

        ' 再選択
        If (idx > 0) Then
            cmbQuestion.SelectedIndex = idx - 1
        Else
            cmbQuestion.SelectedIndex = str.Length - 1
        End If
    End Sub

    ''' <summary>
    ''' cmbQuestion の内容を配列化する
    ''' </summary>
    ''' <returns></returns>
    Private Function cmbQuestionItemsToArray() As String()
        Dim s As Integer = cmbQuestion.Items.Count
        Dim str() As String = New String(s - 1) {}
        With cmbQuestion
            For i = 0 To s - 1 Step 1
                str(i) = .Items(i).ToString()
            Next i
        End With
        Return str
    End Function

    ''' <summary>
    ''' 答えの一覧から JSON をエンコードする
    ''' </summary>
    ''' <returns></returns>
    Private Function encodeQuestions() As String
        Dim str As String = ""

        With cmbQuestion
            Dim s As Integer = .Items.Count
            If (s > 1) Then
                str &= "["
                For i As Integer = 0 To s - 1 Step 1
                    Dim t As String = .Items.Item(i).ToString().Trim()
                    t.Replace("""", "\""")  ' 文字列エスケープ
                    str &= """" & t & """, "
                Next i
                Return str.Substring(0, str.Length - 2) & "]"
            ElseIf (s = 1) Then
                Dim t As String = .Items.Item(0).ToString().Trim()
                Return """" & t.Replace("""", "\""") & """"
            Else
                ' 入力欄に記入されていれば
                Dim t As String = .Text.ToString().Trim()
                If t.Length > 0 Then
                    Return """" & t & """"
                Else
                    Return ""
                End If
            End If
        End With
    End Function

    ''' <summary>
    ''' 答えの一覧の JSON をデコードする
    ''' </summary>
    ''' <param name="q"></param>
    ''' <returns></returns>
    Private Function decodeQuestions(ByVal q As String) As String()
        q = q.Trim()    ' とりあえずトリム
        If (System.Text.RegularExpressions.Regex.IsMatch(q, "\[.+\]")) Then
            ' 配列だ (ここのパーサーをもっと賢く)
            'q = q.Substring(1, q.Length - 2)
            'Dim ary() As String = Split(q, ", ")
            'Dim s As Integer = ary.Length
            'For i As Integer = 0 To s - 1 Step 1
            '    ary(i) = ary(i).Substring(1, ary(i).Length - 2)
            'Next i
            'Return ary
            Return questionsParser(q)
        Else
            Return New String() {q.Substring(1, q.Length - 2)}
        End If
    End Function

    ''' <summary>
    ''' 問題の配列 JSON をパースする
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    Private Function questionsParser(ByVal str As String) As String()
        Dim lst As List(Of String) = New List(Of String)

        Dim s As Integer = str.Length
        Dim i As Integer = 0    ' カウンター
        Dim c As Char   ' 文字
        Dim status As Integer = 0   ' 状態
        Dim t As String = ""    ' 文字列仮

        While (i < s)
            c = str.Chars(i)
            Select Case status
                Case 0  ' 配列開始の探索
                    If (c = "[") Then
                        status = 1
                    ElseIf (c <> " ") Then
                        Exit While
                    End If

                Case 1  ' 項目の開始の探索
                    If (c = """") Then
                        t = ""
                        status = 2
                    ElseIf (c <> " ") Then
                        Exit While
                    End If

                Case 2  ' 項目中の文字列
                    If (c = "\") Then
                        status = 3
                    ElseIf (c = """") Then
                        lst.Add(t)
                        status = 4
                    Else
                        t &= c
                    End If

                Case 3  ' エスケープ
                    If (c = """") Then
                        t &= """"
                        status = 2
                    Else
                        t &= "\" & c
                        status = 2
                    End If

                Case 4  ' 項目の終端、配列の終端の探索
                    If (c = ",") Then
                        status = 1
                    ElseIf (c = "]") Then
                        status = 5
                        Exit While
                    ElseIf (c <> " ") Then
                        Exit While
                    End If
            End Select
            i += 1
        End While

        ' 正常終了したかチェック
        If (status = 5) Then
            Return lst.ToArray()
        Else
            Return New String() {}
        End If
    End Function


    ' ===================================
    '   答え
    ' ===================================

    ''' <summary>
    ''' btnAnsClear が押されたら、答えをクリアー
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAnsClear_Click(sender As System.Object, e As System.EventArgs) Handles btnAnsClear.Click
        txtAns.Text = ""
    End Sub

    ''' <summary>
    ''' txtAns のショートカット
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtAns_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAns.KeyUp
        If (e.Control And e.Shift And e.KeyCode = Keys.Enter) Then
            ' Ctrl + Shift + Enter で項目の追加
            If (btnAdd.Visible) Then
                btnAdd_Click(sender, e)
            ElseIf (btnUpdate.Visible) Then
                btnUpdate_Click(sender, e)
            End If
        End If
    End Sub

    ' ===================================
    '   解説
    ' ===================================

    ''' <summary>
    ''' btnCommentClear が押されたら、解説をクリアー
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCommentClear_Click(sender As System.Object, e As System.EventArgs) Handles btnCommentClear.Click
        txtComment.Text = ""
    End Sub

    ''' <summary>
    ''' 全部クリアーする
    ''' </summary>
    Private Sub txtCommentAllReset()
        txtComment.Text = ""
    End Sub

    ''' <summary>
    ''' txtComment のショートカットキー
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtComment_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtComment.KeyUp
        If (e.Control And e.Shift And e.KeyCode = Keys.Enter) Then
            ' Ctrl + Shift + Enter で項目の追加
            If (btnAdd.Visible) Then
                btnAdd_Click(sender, e)
            ElseIf (btnUpdate.Visible) Then
                btnUpdate_Click(sender, e)
            End If
        End If
    End Sub


    ' ===================================
    '   入力データ
    ' ===================================

    ''' <summary>
    ''' 入力データがクリックされたら状態解除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lstCards_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles lstCards.CellClick
        ' 初期化
        txtAns.Text = ""
        cmbQuestion.Items.Clear()
        txtComment.Text = ""

        ' 表示、非表示
        btnAdd.Visible = True
        btnUpdate.Visible = False
    End Sub

    ''' <summary>
    ''' 入力データをダブルクリックしたら編集状態に
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lstCards_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles lstCards.CellDoubleClick
        Dim idx As Integer = e.RowIndex

        ' どのセルもクリックしていない
        If (idx < 0) Then
            Exit Sub
        End If

        Dim t As String ' たたき台
        With lstCards.Rows(idx)
            t = .Cells(0).Value.ToString()
            txtAns.Text = t.Substring(1, t.Length - 2)

            Dim ary() As String = decodeQuestions(.Cells(1).Value.ToString())
            cmbQuestion.Items.Clear()
            cmbQuestion.Items.AddRange(ary)

            t = .Cells(2).Value.ToString()
            If (t.Length > 0) Then
                txtComment.Text = t.Substring(1, t.Length - 2)
            Else
                txtComment.Text = ""
            End If
        End With

        btnAdd.Visible = False
        btnUpdate.Visible = True
    End Sub

    ''' <summary>
    ''' 上へボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCardUp_Click(sender As System.Object, e As System.EventArgs) Handles btnCardUp.Click
        ' データがない
        If lstCards.RowCount < 1 Then
            Exit Sub
        End If

        Dim idx As Integer = lstCards.CurrentRow.Index

        ' 選択してない
        If (idx < 0 Or lstCards.SelectedRows.Count < 0) Then
            Exit Sub
        End If

        ' コピー
        Dim lst(lstCards.Rows.Count - 1) As DataGridViewRow
        For i As Integer = lstCards.Rows.Count - 1 To 0 Step -1
            lst(i) = lstCards.Rows(i)
        Next i

        Dim s As Integer = lstCards.Rows.Count
        If (idx > 0) Then
            Dim t As DataGridViewRow = lst(idx)
            lst(idx) = lst(idx - 1)
            lst(idx - 1) = t
        Else
            Dim t As DataGridViewRow = lst(0)
            For i As Integer = 1 To s - 1
                lst(i - 1) = lst(i)
            Next i
            lst(s - 1) = t
        End If

        ' 再描画
        lstCards.Rows.Clear()
        lstCards.Rows.AddRange(lst)

        ' 再選択
        If (idx > 0) Then
            lstCards.Rows(idx - 1).Cells(0).Selected = True
        Else
            lstCards.Rows(s - 1).Cells(0).Selected = True
        End If

        ' 変更した
        changedFlag = True
    End Sub

    ''' <summary>
    ''' 下へボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCardDown_Click(sender As System.Object, e As System.EventArgs) Handles btnCardDown.Click
        ' データがない
        If lstCards.RowCount < 1 Then
            Exit Sub
        End If

        Dim idx As Integer = lstCards.CurrentRow.Index

        ' 選択してない
        If (idx < 0 Or lstCards.SelectedRows.Count < 0) Then
            Exit Sub
        End If

        ' コピー
        Dim lst(lstCards.Rows.Count - 1) As DataGridViewRow
        For i As Integer = lstCards.Rows.Count - 1 To 0 Step -1
            lst(i) = lstCards.Rows(i)
        Next i

        Dim s As Integer = lstCards.Rows.Count
        If (idx <> s - 1) Then
            Dim t As DataGridViewRow = lst(idx)
            lst(idx) = lst(idx + 1)
            lst(idx + 1) = t
        Else
            Dim t As DataGridViewRow = lst(s - 1)
            For i As Integer = s - 2 To 0 Step -1
                lst(i + 1) = lst(i)
            Next i
            lst(0) = t
        End If

        ' 再描画
        lstCards.Rows.Clear()
        lstCards.Rows.AddRange(lst)

        ' 再選択
        If (idx <> s - 1) Then
            lstCards.Rows(idx + 1).Cells(0).Selected = True
        Else
            lstCards.Rows(0).Cells(0).Selected = True
        End If

        ' 変更した
        changedFlag = True
    End Sub

    ''' <summary>
    ''' 項目を右クリックしたら、選択してメニューを出す
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lstCards_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles lstCards.CellMouseClick
        If (e.Button = Windows.Forms.MouseButtons.Right) Then
            If (e.RowIndex >= 0) Then
                lstCards.Rows(e.RowIndex).Cells(0).Selected = True
                ContextMenuStrip1.Show(MousePosition)
            End If
        End If
    End Sub


    ' ===================================
    '   入力データのコンテキストメニュー
    ' ===================================

    ''' <summary>
    ''' 変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UpdateUToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpdateUToolStripMenuItem.Click
        Dim e2 As DataGridViewCellEventArgs = New DataGridViewCellEventArgs(lstCards.CurrentCell.ColumnIndex, lstCards.CurrentCell.RowIndex)
        lstCards_CellDoubleClick(sender, e2)
    End Sub

    ''' <summary>
    ''' 削除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RemoveRToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveRToolStripMenuItem.Click
        btnCardRemove_Click(sender, e)
    End Sub

    ''' <summary>
    ''' 解除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Dim e2 As DataGridViewCellEventArgs = New DataGridViewCellEventArgs(lstCards.CurrentCell.ColumnIndex, lstCards.CurrentCell.RowIndex)
        lstCards_CellClick(sender, e2)
    End Sub

    ''' <summary>
    ''' 上へ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToUpPToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ToUpPToolStripMenuItem.Click
        btnCardUp_Click(sender, e)
    End Sub

    ''' <summary>
    ''' 下へ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToDownDToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ToDownDToolStripMenuItem.Click
        btnCardDown_Click(sender, e)
    End Sub


    ' ===================================
    '   ファイルの出力
    ' ===================================

    ''' <summary>
    ''' ファイルを出力する
    ''' </summary>
    ''' <param name="fp"></param>
    Private Sub outputJS(ByVal fp As String)
        Try
            Dim sw As New System.IO.StreamWriter(fp, False, System.Text.Encoding.GetEncoding("shift_jis"))
            sw.Write(encodeCardsJS())
            sw.Close()
            openedFilePath = fp
            changedFlag = False
        Catch ex As Exception
            MessageBox.Show("ファイルの出力に失敗しました。", "CardsJSEditor")
        End Try
    End Sub

    ''' <summary>
    ''' lstCards から cards.js をエンコードする
    ''' </summary>
    ''' <returns></returns>
    Private Function encodeCardsJS() As String
        Dim str As String

        If (radioCards.Checked) Then
            str = "var tagMaster = [" & vbCrLf
        Else
            str = "var dummyMaster = [" & vbCrLf
        End If

        With lstCards
            Dim s As Integer = .Rows.Count
            For i As Integer = 0 To s - 1 Step 1
                str &= vbTab & String.Format("new Tag({0}, {1}", .Rows(i).Cells(0).Value.ToString(), .Rows(i).Cells(1).Value.ToString())
                Dim com = .Rows(i).Cells(2).Value.ToString()
                If (com.Length > 0) Then
                    str &= String.Format(", {0}),", com) & vbCrLf
                Else
                    str &= ")," & vbCrLf
                End If
            Next i
        End With

        str = str.TrimEnd()

        Return str.Substring(0, str.Length - 1) & vbCrLf & "];"
    End Function


    ' ===================================
    '   ファイルの入力
    ' ===================================

    ''' <summary>
    ''' ファイルを開くメソッド
    ''' </summary>
    ''' <param name="fn"></param>
    Private Sub inputJS(ByVal fn As String)
        Dim sr As System.IO.StreamReader = Nothing

        ' 全部消す
        lstCards.Rows.Clear()

        Try
            sr = New System.IO.StreamReader(fn, System.Text.Encoding.GetEncoding("shift_jis"))
            Dim str As String = sr.ReadLine().Trim()
            Dim cnt As Integer = 2

            ' 1 行目が正常
            If (str = "var tagMaster = [" Or str = "var dummyMaster = [") Then

                If (str = "var tagMaster = [") Then
                    radioCards.Checked = True
                Else
                    radioDummy.Checked = True
                End If

                str = sr.ReadLine().Trim()
                While (str <> "];")
                    Dim acard As Card

                    ' 終端かチェック
                    If (Not IsNothing(str)) Then

                        ' その行の特性をチェック
                        If (str.Length = 0 Or str.IndexOf("//") = 0 Or str.IndexOf("/*") = 0) Then
                            ' 空行、コメント行なら無視
                            str = sr.ReadLine().Trim()
                            cnt += 1
                            Continue While
                        Else
                            ' おそらくデータ行
                            acard = CardParser(str)
                        End If

                    Else
                        Throw (New Exception("ファイルの終了が異常です:" & cnt))
                    End If

                    If (Not IsNothing(acard)) Then
                        lstCards.Rows.Add(acard.getAnswer, acard.getQuestions, acard.getComment)
                    Else
                        Throw (New Exception("ファイルの文法エラーです:" & cnt))
                    End If

                    str = sr.ReadLine().Trim()
                    cnt += 1
                End While

                ' 開かれたファイル名
                openedFilePath = fn
                changedFlag = False
            Else
                Throw (New Exception("ファイルの文法エラーです:1"))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ' ファイルを閉じる
            If (Not IsNothing(sr)) Then
                sr.Close()
            End If
        End Try
    End Sub

    ''' <summary>
    ''' cards.js の Card コンストラクタのパーサー (そんなに賢くない)
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    Private Function CardParser(ByVal str As String) As Card
        Dim answer As String = Nothing
        Dim question As String = Nothing
        Dim comment As String = Nothing

        ' とりあえずトリム
        str = str.Trim()
        Dim idx As Integer = str.IndexOf("new Tag(")  ' 冒頭があるか調べる
        If (idx <> 0) Then
            Return Nothing
        End If
        str = str.Substring(8)

        Dim i As Integer = 0
        Dim size As Integer = str.Length

        Dim state As Integer = 0
        Dim tAns As String = ""
        Dim tQue As String = ""
        Dim tCom As String = ""
        Dim t As String = ""
        Dim c As Char

        While (i < size)
            c = str.Chars(i)
            Select Case state
                Case 0  ' answer の文字列の開始
                    If (c = """") Then
                        state = 1
                    ElseIf (c <> " ") Then
                        Exit While
                    End If

                Case 1  ' answer の文字列中
                    If (c = "\") Then   ' エスケープ
                        state = 2
                    ElseIf (c = """") Then  ' answer の終了
                        state = 3
                    Else
                        tAns &= c
                    End If

                Case 2  ' answer のエスケープ中
                    If (c = """") Then  ' " のエスケープ
                        tAns &= """"
                    Else
                        tAns &= "\" & c
                    End If
                    state = 1

                Case 3  ' answer の終了後の処理
                    If (c = ",") Then   ' 次の questions へ
                        answer = """" & tAns & """"
                        state = 10
                    ElseIf (c <> " ") Then
                        Exit While
                    End If

                Case 10 ' questions の開始部分を探す
                    If (c = "[") Then   ' 配列 question
                        state = 101
                    ElseIf (c = """") Then  ' 文字列 question
                        state = 111
                    ElseIf (c <> " ") Then
                        Exit While
                    End If

                Case 101    ' 配列 question の各項目開始
                    If (c = """") Then  ' 文字列開始
                        state = 102
                    ElseIf (c <> " ") Then
                        Exit While
                    End If

                Case 102    ' 配列 question の各項目中
                    If (c = "\") Then   ' エスケープ
                        state = 103
                    ElseIf (c = """") Then  ' 各項目終了
                        state = 104
                    Else
                        t &= c
                    End If

                Case 103    ' 配列 question の各項目エスケープ
                    If (c = """") Then
                        t &= """"
                    Else
                        t &= "\" & c
                    End If
                    state = 102

                Case 104    ' 配列 question 各項目終了
                    If (c = ",") Then   ' 次の項目へ
                        tQue &= """" & t & """, "
                        t = ""
                        state = 101
                    ElseIf (c = "]") Then   ' 配列終了
                        question = "[" & tQue & """" & t & """" & "]"
                        state = 105
                    ElseIf (c <> " ") Then
                        Exit While
                    End If

                Case 105    ' 配列 question 終了後
                    If (c = ",") Then   ' 次 comment
                        state = 20
                    ElseIf (c = ")") Then   ' 終了
                        state = 30
                        Exit While
                    ElseIf (c <> " ") Then
                        Exit While
                    End If

                Case 111    ' 文字列 question の中身
                    If (c = "\") Then   ' エスケープ
                        state = 112
                    ElseIf (c = """") Then  ' 文字列 question の終了
                        state = 113
                    Else
                        tQue &= c
                    End If

                Case 112    ' 文字列 question のエスケープ
                    If (c = """") Then  ' " のエスケープ
                        tQue &= """"
                    Else
                        tQue &= "\" & c
                    End If
                    state = 111

                Case 113    ' 文字列 question の終了後
                    If (c = ",") Then   ' 次 comment
                        question = """" & tQue & """"
                        state = 20
                    ElseIf (c = ")") Then   ' Card 終了
                        question = """" & tQue & """"
                        state = 30
                        Exit While
                    ElseIf (c <> " ") Then
                        Exit While
                    End If

                Case 20 ' comment 開始
                    If (c = """") Then
                        state = 21
                    ElseIf (c <> " ") Then
                        Exit While
                    End If

                Case 21 ' comment 文字列
                    If (c = "\") Then   ' エスケープ
                        state = 22
                    ElseIf (c = """") Then  ' comment 終了
                        state = 23
                    Else
                        tCom &= c
                    End If

                Case 22 ' comment エスケープ中
                    If (c = """") Then  ' " のエスケープ
                        tCom &= """"
                    Else
                        tCom &= "\" & c
                    End If
                    state = 21

                Case 23 ' comment 終了後
                    If (c = ")") Then   ' Card の終了
                        comment = """" & tCom & """"
                        state = 30
                        Exit While
                    ElseIf (c <> " ") Then
                        Exit While
                    End If
            End Select
            i += 1
        End While

        If (state = 30) Then
            If (IsNothing(comment)) Then
                Return New Card(answer, question)
            Else
                Return New Card(answer, question, comment)
            End If
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' CSV ファイルの読み込み
    ''' </summary>
    ''' <param name="fn"></param>
    ''' <returns></returns>
    Private Function importCSV(ByVal fn As String) As Boolean
        Dim sr As System.IO.StreamReader = Nothing

        Try
            sr = New System.IO.StreamReader(fn, System.Text.Encoding.GetEncoding("shift_jis"))

            Dim gyo As String = ""
            gyo = sr.ReadLine.Trim()
            Do While Not sr.EndOfStream
                Dim ary() As String = gyo.Split(",")
                Select Case ary.Length
                    Case Is > 2
                        lstCards.Rows.Add("""" & ary(0).Trim() & """", """" & ary(1).Trim() & """", """" & ary(2).Trim() & """")
                    Case 2
                        lstCards.Rows.Add("""" & ary(0).Trim() & """", """" & ary(1).Trim() & """", "")
                    Case Else

                End Select

                gyo = sr.ReadLine.Trim()
            Loop

            sr.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "CardsJSEditor")

            If Not (IsNothing(sr)) Then
                sr.Close()
            End If
            Return False
        End Try
    End Function

End Class

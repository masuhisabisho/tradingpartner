'
' Created by SharpDevelop.
' User: madman190382
' Date: 2013/06/09
' Time: 17:57
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Main
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.Pnl_Header = New System.Windows.Forms.Panel()
		Me.Lbl_Branch = New System.Windows.Forms.Label()
		Me.Lbl_Time = New System.Windows.Forms.Label()
		Me.Lbl_Usr = New System.Windows.Forms.Label()
		Me.Lbl_Date = New System.Windows.Forms.Label()
		Me.Pnl_Main = New System.Windows.Forms.Panel()
		Me.Pnl_Menu = New System.Windows.Forms.Panel()
		Me.Btn_Analyze = New System.Windows.Forms.Button()
		Me.Btn_Fee = New System.Windows.Forms.Button()
		Me.Btn_Master = New System.Windows.Forms.Button()
		Me.Btn_Mail = New System.Windows.Forms.Button()
		Me.Btn_Report = New System.Windows.Forms.Button()
		Me.Btn_Quote = New System.Windows.Forms.Button()
		Me.Btn_Search = New System.Windows.Forms.Button()
		Me.Brn_Order = New System.Windows.Forms.Button()
		Me.Pnl_Header.SuspendLayout
		Me.Pnl_Menu.SuspendLayout
		Me.SuspendLayout
		'
		'Pnl_Header
		'
		Me.Pnl_Header.Controls.Add(Me.Lbl_Branch)
		Me.Pnl_Header.Controls.Add(Me.Lbl_Time)
		Me.Pnl_Header.Controls.Add(Me.Lbl_Usr)
		Me.Pnl_Header.Controls.Add(Me.Lbl_Date)
		Me.Pnl_Header.Location = New System.Drawing.Point(0, 5)
		Me.Pnl_Header.Name = "Pnl_Header"
		Me.Pnl_Header.Size = New System.Drawing.Size(709, 24)
		Me.Pnl_Header.TabIndex = 0
		'
		'Lbl_Branch
		'
		Me.Lbl_Branch.BackColor = System.Drawing.Color.White
		Me.Lbl_Branch.Location = New System.Drawing.Point(323, 1)
		Me.Lbl_Branch.Name = "Lbl_Branch"
		Me.Lbl_Branch.Size = New System.Drawing.Size(100, 20)
		Me.Lbl_Branch.TabIndex = 3
		Me.Lbl_Branch.Text = "label4"
		'
		'Lbl_Time
		'
		Me.Lbl_Time.BackColor = System.Drawing.Color.White
		Me.Lbl_Time.Location = New System.Drawing.Point(4, 1)
		Me.Lbl_Time.Name = "Lbl_Time"
		Me.Lbl_Time.Size = New System.Drawing.Size(100, 20)
		Me.Lbl_Time.TabIndex = 0
		Me.Lbl_Time.Text = "label1"
		'
		'Lbl_Usr
		'
		Me.Lbl_Usr.BackColor = System.Drawing.Color.White
		Me.Lbl_Usr.Location = New System.Drawing.Point(217, 1)
		Me.Lbl_Usr.Name = "Lbl_Usr"
		Me.Lbl_Usr.Size = New System.Drawing.Size(100, 20)
		Me.Lbl_Usr.TabIndex = 2
		Me.Lbl_Usr.Text = "label3"
		'
		'Lbl_Date
		'
		Me.Lbl_Date.BackColor = System.Drawing.Color.White
		Me.Lbl_Date.Location = New System.Drawing.Point(111, 1)
		Me.Lbl_Date.Name = "Lbl_Date"
		Me.Lbl_Date.Size = New System.Drawing.Size(100, 20)
		Me.Lbl_Date.TabIndex = 1
		Me.Lbl_Date.Text = "label2"
		'
		'Pnl_Main
		'
		Me.Pnl_Main.Location = New System.Drawing.Point(1, 116)
		Me.Pnl_Main.Name = "Pnl_Main"
		Me.Pnl_Main.Size = New System.Drawing.Size(708, 343)
		Me.Pnl_Main.TabIndex = 1
		'
		'Pnl_Menu
		'
		Me.Pnl_Menu.Controls.Add(Me.Btn_Analyze)
		Me.Pnl_Menu.Controls.Add(Me.Btn_Fee)
		Me.Pnl_Menu.Controls.Add(Me.Btn_Master)
		Me.Pnl_Menu.Controls.Add(Me.Btn_Mail)
		Me.Pnl_Menu.Controls.Add(Me.Btn_Report)
		Me.Pnl_Menu.Controls.Add(Me.Btn_Quote)
		Me.Pnl_Menu.Controls.Add(Me.Btn_Search)
		Me.Pnl_Menu.Controls.Add(Me.Brn_Order)
		Me.Pnl_Menu.Location = New System.Drawing.Point(0, 38)
		Me.Pnl_Menu.Name = "Pnl_Menu"
		Me.Pnl_Menu.Size = New System.Drawing.Size(709, 67)
		Me.Pnl_Menu.TabIndex = 2
		'
		'Btn_Analyze
		'
		Me.Btn_Analyze.Location = New System.Drawing.Point(380, 2)
		Me.Btn_Analyze.Name = "Btn_Analyze"
		Me.Btn_Analyze.Size = New System.Drawing.Size(75, 63)
		Me.Btn_Analyze.TabIndex = 7
		Me.Btn_Analyze.Text = "分析帳票"
		Me.Btn_Analyze.UseVisualStyleBackColor = true
		AddHandler Me.Btn_Analyze.Click, AddressOf Me.Btn_Analyze_Click
		'
		'Btn_Fee
		'
		Me.Btn_Fee.Location = New System.Drawing.Point(154, 2)
		Me.Btn_Fee.Name = "Btn_Fee"
		Me.Btn_Fee.Size = New System.Drawing.Size(75, 63)
		Me.Btn_Fee.TabIndex = 6
		Me.Btn_Fee.Text = "費用登録"
		Me.Btn_Fee.UseVisualStyleBackColor = true
		AddHandler Me.Btn_Fee.Click, AddressOf Me.Btn_Fee_Click
		'
		'Btn_Master
		'
		Me.Btn_Master.Location = New System.Drawing.Point(531, 2)
		Me.Btn_Master.Name = "Btn_Master"
		Me.Btn_Master.Size = New System.Drawing.Size(75, 63)
		Me.Btn_Master.TabIndex = 5
		Me.Btn_Master.Text = "マスタ管理"
		Me.Btn_Master.UseVisualStyleBackColor = true
		AddHandler Me.Btn_Master.Click, AddressOf Me.Btn_Master_Click
		'
		'Btn_Mail
		'
		Me.Btn_Mail.Location = New System.Drawing.Point(456, 2)
		Me.Btn_Mail.Name = "Btn_Mail"
		Me.Btn_Mail.Size = New System.Drawing.Size(75, 63)
		Me.Btn_Mail.TabIndex = 4
		Me.Btn_Mail.Text = "メール送信"
		Me.Btn_Mail.UseVisualStyleBackColor = true
		AddHandler Me.Btn_Mail.Click, AddressOf Me.Btn_Mail_Click
		'
		'Btn_Report
		'
		Me.Btn_Report.Location = New System.Drawing.Point(304, 2)
		Me.Btn_Report.Name = "Btn_Report"
		Me.Btn_Report.Size = New System.Drawing.Size(75, 63)
		Me.Btn_Report.TabIndex = 3
		Me.Btn_Report.Text = "帳票出力"
		Me.Btn_Report.UseVisualStyleBackColor = true
		AddHandler Me.Btn_Report.Click, AddressOf Me.Btn_Report_Click
		'
		'Btn_Quote
		'
		Me.Btn_Quote.Location = New System.Drawing.Point(229, 2)
		Me.Btn_Quote.Name = "Btn_Quote"
		Me.Btn_Quote.Size = New System.Drawing.Size(75, 63)
		Me.Btn_Quote.TabIndex = 2
		Me.Btn_Quote.Text = "見積作成"
		Me.Btn_Quote.UseVisualStyleBackColor = true
		AddHandler Me.Btn_Quote.Click, AddressOf Me.Btn_Quote_Click
		'
		'Btn_Search
		'
		Me.Btn_Search.Location = New System.Drawing.Point(79, 2)
		Me.Btn_Search.Name = "Btn_Search"
		Me.Btn_Search.Size = New System.Drawing.Size(75, 63)
		Me.Btn_Search.TabIndex = 1
		Me.Btn_Search.Text = "検索"
		Me.Btn_Search.UseVisualStyleBackColor = true
		AddHandler Me.Btn_Search.Click, AddressOf Me.Btn_Search_Click
		'
		'Brn_Order
		'
		Me.Brn_Order.Location = New System.Drawing.Point(4, 2)
		Me.Brn_Order.Name = "Brn_Order"
		Me.Brn_Order.Size = New System.Drawing.Size(75, 63)
		Me.Brn_Order.TabIndex = 0
		Me.Brn_Order.Text = "受注業務"
		Me.Brn_Order.UseVisualStyleBackColor = true
		AddHandler Me.Brn_Order.Click, AddressOf Me.Brn_Order_Click
		'
		'Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(710, 460)
		Me.Controls.Add(Me.Pnl_Menu)
		Me.Controls.Add(Me.Pnl_Main)
		Me.Controls.Add(Me.Pnl_Header)
		Me.Name = "Main"
		Me.Text = "メイン"
		Me.Pnl_Header.ResumeLayout(false)
		Me.Pnl_Menu.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private Btn_Analyze As System.Windows.Forms.Button
	Private Btn_Report As System.Windows.Forms.Button
	Private Lbl_Date As System.Windows.Forms.Label
	Private Lbl_Usr As System.Windows.Forms.Label
	Private Lbl_Time As System.Windows.Forms.Label
	Private Lbl_Branch As System.Windows.Forms.Label
	Private Btn_Fee As System.Windows.Forms.Button
	Private Brn_Order As System.Windows.Forms.Button
	Private Btn_Search As System.Windows.Forms.Button
	Private Btn_Quote As System.Windows.Forms.Button
	Private Btn_Mail As System.Windows.Forms.Button
	Private Btn_Master As System.Windows.Forms.Button
	Private Pnl_Menu As System.Windows.Forms.Panel
	Private Pnl_Main As System.Windows.Forms.Panel
	Private Pnl_Header As System.Windows.Forms.Panel
	Private timer1 As System.Windows.Forms.Timer
End Class

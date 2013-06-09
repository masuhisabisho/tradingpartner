'
' Created by SharpDevelop.
' User: madman190382
' Date: 2013/06/09
' Time: 19:08
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class SearchGridvb
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
		Me.Dgv_Order = New System.Windows.Forms.DataGridView()
		Me.Btn_Search = New System.Windows.Forms.Button()
		Me.Lbl_Customer = New System.Windows.Forms.Label()
		Me.Lbl_Port = New System.Windows.Forms.Label()
		Me.Llb_Quote = New System.Windows.Forms.Label()
		Me.Lbl_Jan = New System.Windows.Forms.Label()
		Me.Lbl_PO = New System.Windows.Forms.Label()
		Me.Lbl_Item = New System.Windows.Forms.Label()
		Me.Lbl_PI = New System.Windows.Forms.Label()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.Rdo_Adv = New System.Windows.Forms.RadioButton()
		Me.Rdo_Doc = New System.Windows.Forms.RadioButton()
		Me.Rdo_Pay = New System.Windows.Forms.RadioButton()
		Me.Rdo_Order = New System.Windows.Forms.RadioButton()
		Me.Rdo_Vessel = New System.Windows.Forms.RadioButton()
		Me.Rdo_Agent = New System.Windows.Forms.RadioButton()
		Me.Rdo_WH = New System.Windows.Forms.RadioButton()
		Me.Rdo_PI = New System.Windows.Forms.RadioButton()
		Me.Btn_Clear = New System.Windows.Forms.Button()
		Me.Txt_Csno = New System.Windows.Forms.TextBox()
		Me.Txt_PO = New System.Windows.Forms.TextBox()
		Me.Txt_PI = New System.Windows.Forms.TextBox()
		Me.Txt_Item = New System.Windows.Forms.TextBox()
		Me.Txt_Jan = New System.Windows.Forms.TextBox()
		Me.Txt_Quote = New System.Windows.Forms.TextBox()
		Me.Txt_Port = New System.Windows.Forms.TextBox()
		CType(Me.Dgv_Order,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox1.SuspendLayout
		Me.SuspendLayout
		'
		'Dgv_Order
		'
		Me.Dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.Dgv_Order.Location = New System.Drawing.Point(12, 256)
		Me.Dgv_Order.Name = "Dgv_Order"
		Me.Dgv_Order.RowTemplate.Height = 21
		Me.Dgv_Order.Size = New System.Drawing.Size(700, 312)
		Me.Dgv_Order.TabIndex = 1
		'
		'Btn_Search
		'
		Me.Btn_Search.Location = New System.Drawing.Point(650, 137)
		Me.Btn_Search.Name = "Btn_Search"
		Me.Btn_Search.Size = New System.Drawing.Size(93, 50)
		Me.Btn_Search.TabIndex = 2
		Me.Btn_Search.Text = "検索"
		Me.Btn_Search.UseVisualStyleBackColor = true
		'
		'Lbl_Customer
		'
		Me.Lbl_Customer.BackColor = System.Drawing.Color.Navy
		Me.Lbl_Customer.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl_Customer.Location = New System.Drawing.Point(12, 9)
		Me.Lbl_Customer.Name = "Lbl_Customer"
		Me.Lbl_Customer.Size = New System.Drawing.Size(100, 22)
		Me.Lbl_Customer.TabIndex = 9
		Me.Lbl_Customer.Text = "お客様番号："
		Me.Lbl_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Lbl_Port
		'
		Me.Lbl_Port.BackColor = System.Drawing.Color.Navy
		Me.Lbl_Port.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl_Port.Location = New System.Drawing.Point(535, 9)
		Me.Lbl_Port.Name = "Lbl_Port"
		Me.Lbl_Port.Size = New System.Drawing.Size(100, 22)
		Me.Lbl_Port.TabIndex = 10
		Me.Lbl_Port.Text = "向け地："
		Me.Lbl_Port.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Llb_Quote
		'
		Me.Llb_Quote.BackColor = System.Drawing.Color.Navy
		Me.Llb_Quote.ForeColor = System.Drawing.Color.Yellow
		Me.Llb_Quote.Location = New System.Drawing.Point(265, 9)
		Me.Llb_Quote.Name = "Llb_Quote"
		Me.Llb_Quote.Size = New System.Drawing.Size(100, 22)
		Me.Llb_Quote.TabIndex = 11
		Me.Llb_Quote.Text = "見積番号："
		Me.Llb_Quote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Lbl_Jan
		'
		Me.Lbl_Jan.BackColor = System.Drawing.Color.Navy
		Me.Lbl_Jan.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl_Jan.Location = New System.Drawing.Point(265, 50)
		Me.Lbl_Jan.Name = "Lbl_Jan"
		Me.Lbl_Jan.Size = New System.Drawing.Size(100, 22)
		Me.Lbl_Jan.TabIndex = 12
		Me.Lbl_Jan.Text = "見積Jan："
		Me.Lbl_Jan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Lbl_PO
		'
		Me.Lbl_PO.BackColor = System.Drawing.Color.Navy
		Me.Lbl_PO.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl_PO.Location = New System.Drawing.Point(12, 53)
		Me.Lbl_PO.Name = "Lbl_PO"
		Me.Lbl_PO.Size = New System.Drawing.Size(100, 22)
		Me.Lbl_PO.TabIndex = 13
		Me.Lbl_PO.Text = "P/O番号："
		Me.Lbl_PO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Lbl_Item
		'
		Me.Lbl_Item.BackColor = System.Drawing.Color.Navy
		Me.Lbl_Item.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl_Item.Location = New System.Drawing.Point(265, 31)
		Me.Lbl_Item.Name = "Lbl_Item"
		Me.Lbl_Item.Size = New System.Drawing.Size(100, 22)
		Me.Lbl_Item.TabIndex = 14
		Me.Lbl_Item.Text = "見積商品："
		Me.Lbl_Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Lbl_PI
		'
		Me.Lbl_PI.BackColor = System.Drawing.Color.Navy
		Me.Lbl_PI.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl_PI.Location = New System.Drawing.Point(12, 31)
		Me.Lbl_PI.Name = "Lbl_PI"
		Me.Lbl_PI.Size = New System.Drawing.Size(100, 22)
		Me.Lbl_PI.TabIndex = 15
		Me.Lbl_PI.Text = "P/I番号："
		Me.Lbl_PI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'groupBox1
		'
		Me.groupBox1.BackColor = System.Drawing.Color.Navy
		Me.groupBox1.Controls.Add(Me.Rdo_Adv)
		Me.groupBox1.Controls.Add(Me.Rdo_Doc)
		Me.groupBox1.Controls.Add(Me.Rdo_Pay)
		Me.groupBox1.Controls.Add(Me.Rdo_Order)
		Me.groupBox1.Controls.Add(Me.Rdo_Vessel)
		Me.groupBox1.Controls.Add(Me.Rdo_Agent)
		Me.groupBox1.Controls.Add(Me.Rdo_WH)
		Me.groupBox1.Controls.Add(Me.Rdo_PI)
		Me.groupBox1.Location = New System.Drawing.Point(48, 87)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(532, 100)
		Me.groupBox1.TabIndex = 16
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "groupBox1"
		'
		'Rdo_Adv
		'
		Me.Rdo_Adv.BackColor = System.Drawing.Color.Transparent
		Me.Rdo_Adv.ForeColor = System.Drawing.Color.Yellow
		Me.Rdo_Adv.Location = New System.Drawing.Point(273, 38)
		Me.Rdo_Adv.Name = "Rdo_Adv"
		Me.Rdo_Adv.Size = New System.Drawing.Size(104, 24)
		Me.Rdo_Adv.TabIndex = 7
		Me.Rdo_Adv.TabStop = true
		Me.Rdo_Adv.Text = "：船積予定未通知"
		Me.Rdo_Adv.UseVisualStyleBackColor = false
		'
		'Rdo_Doc
		'
		Me.Rdo_Doc.BackColor = System.Drawing.Color.Transparent
		Me.Rdo_Doc.ForeColor = System.Drawing.Color.Yellow
		Me.Rdo_Doc.Location = New System.Drawing.Point(273, 18)
		Me.Rdo_Doc.Name = "Rdo_Doc"
		Me.Rdo_Doc.Size = New System.Drawing.Size(104, 24)
		Me.Rdo_Doc.TabIndex = 6
		Me.Rdo_Doc.TabStop = true
		Me.Rdo_Doc.Text = "：書類未送付"
		Me.Rdo_Doc.UseVisualStyleBackColor = false
		'
		'Rdo_Pay
		'
		Me.Rdo_Pay.BackColor = System.Drawing.Color.Transparent
		Me.Rdo_Pay.ForeColor = System.Drawing.Color.Yellow
		Me.Rdo_Pay.Location = New System.Drawing.Point(150, 60)
		Me.Rdo_Pay.Name = "Rdo_Pay"
		Me.Rdo_Pay.Size = New System.Drawing.Size(104, 24)
		Me.Rdo_Pay.TabIndex = 5
		Me.Rdo_Pay.TabStop = true
		Me.Rdo_Pay.Text = "：未入金"
		Me.Rdo_Pay.UseVisualStyleBackColor = false
		'
		'Rdo_Order
		'
		Me.Rdo_Order.BackColor = System.Drawing.Color.Transparent
		Me.Rdo_Order.ForeColor = System.Drawing.Color.Yellow
		Me.Rdo_Order.Location = New System.Drawing.Point(6, 38)
		Me.Rdo_Order.Name = "Rdo_Order"
		Me.Rdo_Order.Size = New System.Drawing.Size(104, 24)
		Me.Rdo_Order.TabIndex = 4
		Me.Rdo_Order.TabStop = true
		Me.Rdo_Order.Text = "：メーカー未発注"
		Me.Rdo_Order.UseVisualStyleBackColor = false
		'
		'Rdo_Vessel
		'
		Me.Rdo_Vessel.BackColor = System.Drawing.Color.Transparent
		Me.Rdo_Vessel.ForeColor = System.Drawing.Color.Yellow
		Me.Rdo_Vessel.Location = New System.Drawing.Point(6, 60)
		Me.Rdo_Vessel.Name = "Rdo_Vessel"
		Me.Rdo_Vessel.Size = New System.Drawing.Size(104, 24)
		Me.Rdo_Vessel.TabIndex = 3
		Me.Rdo_Vessel.TabStop = true
		Me.Rdo_Vessel.Text = "：未Booking"
		Me.Rdo_Vessel.UseVisualStyleBackColor = false
		'
		'Rdo_Agent
		'
		Me.Rdo_Agent.BackColor = System.Drawing.Color.Transparent
		Me.Rdo_Agent.ForeColor = System.Drawing.Color.Yellow
		Me.Rdo_Agent.Location = New System.Drawing.Point(150, 18)
		Me.Rdo_Agent.Name = "Rdo_Agent"
		Me.Rdo_Agent.Size = New System.Drawing.Size(104, 24)
		Me.Rdo_Agent.TabIndex = 2
		Me.Rdo_Agent.TabStop = true
		Me.Rdo_Agent.Text = "：未通関手配"
		Me.Rdo_Agent.UseVisualStyleBackColor = false
		'
		'Rdo_WH
		'
		Me.Rdo_WH.BackColor = System.Drawing.Color.Transparent
		Me.Rdo_WH.ForeColor = System.Drawing.Color.Yellow
		Me.Rdo_WH.Location = New System.Drawing.Point(150, 38)
		Me.Rdo_WH.Name = "Rdo_WH"
		Me.Rdo_WH.Size = New System.Drawing.Size(104, 24)
		Me.Rdo_WH.TabIndex = 1
		Me.Rdo_WH.TabStop = true
		Me.Rdo_WH.Text = "：未搬入"
		Me.Rdo_WH.UseVisualStyleBackColor = false
		'
		'Rdo_PI
		'
		Me.Rdo_PI.BackColor = System.Drawing.Color.Transparent
		Me.Rdo_PI.ForeColor = System.Drawing.Color.Yellow
		Me.Rdo_PI.Location = New System.Drawing.Point(6, 18)
		Me.Rdo_PI.Name = "Rdo_PI"
		Me.Rdo_PI.Size = New System.Drawing.Size(104, 24)
		Me.Rdo_PI.TabIndex = 0
		Me.Rdo_PI.TabStop = true
		Me.Rdo_PI.Text = "：P/I未発行"
		Me.Rdo_PI.UseVisualStyleBackColor = false
		'
		'Btn_Clear
		'
		Me.Btn_Clear.Location = New System.Drawing.Point(650, 75)
		Me.Btn_Clear.Name = "Btn_Clear"
		Me.Btn_Clear.Size = New System.Drawing.Size(93, 50)
		Me.Btn_Clear.TabIndex = 17
		Me.Btn_Clear.Text = "クリア"
		Me.Btn_Clear.UseVisualStyleBackColor = true
		'
		'Txt_Csno
		'
		Me.Txt_Csno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Txt_Csno.Location = New System.Drawing.Point(118, 9)
		Me.Txt_Csno.Name = "Txt_Csno"
		Me.Txt_Csno.Size = New System.Drawing.Size(102, 19)
		Me.Txt_Csno.TabIndex = 18
		'
		'Txt_PO
		'
		Me.Txt_PO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Txt_PO.Location = New System.Drawing.Point(118, 56)
		Me.Txt_PO.Name = "Txt_PO"
		Me.Txt_PO.Size = New System.Drawing.Size(102, 19)
		Me.Txt_PO.TabIndex = 19
		'
		'Txt_PI
		'
		Me.Txt_PI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Txt_PI.Location = New System.Drawing.Point(118, 31)
		Me.Txt_PI.Name = "Txt_PI"
		Me.Txt_PI.Size = New System.Drawing.Size(102, 19)
		Me.Txt_PI.TabIndex = 20
		'
		'Txt_Item
		'
		Me.Txt_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Txt_Item.Location = New System.Drawing.Point(384, 31)
		Me.Txt_Item.Name = "Txt_Item"
		Me.Txt_Item.Size = New System.Drawing.Size(102, 19)
		Me.Txt_Item.TabIndex = 23
		'
		'Txt_Jan
		'
		Me.Txt_Jan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Txt_Jan.Location = New System.Drawing.Point(384, 56)
		Me.Txt_Jan.Name = "Txt_Jan"
		Me.Txt_Jan.Size = New System.Drawing.Size(102, 19)
		Me.Txt_Jan.TabIndex = 22
		'
		'Txt_Quote
		'
		Me.Txt_Quote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Txt_Quote.Location = New System.Drawing.Point(384, 9)
		Me.Txt_Quote.Name = "Txt_Quote"
		Me.Txt_Quote.Size = New System.Drawing.Size(102, 19)
		Me.Txt_Quote.TabIndex = 21
		'
		'Txt_Port
		'
		Me.Txt_Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Txt_Port.Location = New System.Drawing.Point(641, 9)
		Me.Txt_Port.Name = "Txt_Port"
		Me.Txt_Port.Size = New System.Drawing.Size(102, 19)
		Me.Txt_Port.TabIndex = 24
		'
		'SearchGridvb
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(810, 479)
		Me.Controls.Add(Me.Txt_Port)
		Me.Controls.Add(Me.Txt_Item)
		Me.Controls.Add(Me.Txt_Jan)
		Me.Controls.Add(Me.Txt_Quote)
		Me.Controls.Add(Me.Txt_PI)
		Me.Controls.Add(Me.Txt_PO)
		Me.Controls.Add(Me.Txt_Csno)
		Me.Controls.Add(Me.Btn_Clear)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.Lbl_PI)
		Me.Controls.Add(Me.Lbl_Item)
		Me.Controls.Add(Me.Lbl_PO)
		Me.Controls.Add(Me.Lbl_Jan)
		Me.Controls.Add(Me.Llb_Quote)
		Me.Controls.Add(Me.Lbl_Port)
		Me.Controls.Add(Me.Lbl_Customer)
		Me.Controls.Add(Me.Btn_Search)
		Me.Controls.Add(Me.Dgv_Order)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "SearchGridvb"
		Me.Text = "SearchGridvb"
		AddHandler Load, AddressOf Me.SearchGridvb_Load
		CType(Me.Dgv_Order,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox1.ResumeLayout(false)
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private Txt_Port As System.Windows.Forms.TextBox
	Private Txt_Quote As System.Windows.Forms.TextBox
	Private Txt_Jan As System.Windows.Forms.TextBox
	Private Txt_Item As System.Windows.Forms.TextBox
	Private Txt_PI As System.Windows.Forms.TextBox
	Private Txt_PO As System.Windows.Forms.TextBox
	Private Txt_Csno As System.Windows.Forms.TextBox
	Private Btn_Clear As System.Windows.Forms.Button
	Private Rdo_WH As System.Windows.Forms.RadioButton
	Private Rdo_Agent As System.Windows.Forms.RadioButton
	Private Rdo_Vessel As System.Windows.Forms.RadioButton
	Private Rdo_Order As System.Windows.Forms.RadioButton
	Private Rdo_Pay As System.Windows.Forms.RadioButton
	Private Rdo_Doc As System.Windows.Forms.RadioButton
	Private Rdo_Adv As System.Windows.Forms.RadioButton
	Private Rdo_PI As System.Windows.Forms.RadioButton
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private Lbl_Port As System.Windows.Forms.Label
	Private Lbl_PI As System.Windows.Forms.Label
	Private Lbl_Item As System.Windows.Forms.Label
	Private Lbl_PO As System.Windows.Forms.Label
	Private Lbl_Jan As System.Windows.Forms.Label
	Private Llb_Quote As System.Windows.Forms.Label
	Private Lbl_Customer As System.Windows.Forms.Label
	Private Btn_Search As System.Windows.Forms.Button
	Private Dgv_Order As System.Windows.Forms.DataGridView
	
	Sub SearchGridvb_Load(sender As Object, e As EventArgs)
		
	End Sub
End Class

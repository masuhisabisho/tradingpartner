'
' Created by SharpDevelop.
' User: madman190382
' Date: 2013/06/09
' Time: 18:58
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class OrderGrid
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
		CType(Me.Dgv_Order,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'Dgv_Order
		'
		Me.Dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.Dgv_Order.Location = New System.Drawing.Point(2, 1)
		Me.Dgv_Order.Name = "Dgv_Order"
		Me.Dgv_Order.RowTemplate.Height = 21
		Me.Dgv_Order.Size = New System.Drawing.Size(700, 312)
		Me.Dgv_Order.TabIndex = 0
		'
		'OrderGrid
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(701, 316)
		Me.Controls.Add(Me.Dgv_Order)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "OrderGrid"
		Me.Text = "OrderGrid"
		CType(Me.Dgv_Order,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private Dgv_Order As System.Windows.Forms.DataGridView
End Class

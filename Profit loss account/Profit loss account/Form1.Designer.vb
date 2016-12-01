<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmdataentry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.incomelbl = New System.Windows.Forms.Label()
        Me.expendilbl = New System.Windows.Forms.Label()
        Me.salestxt = New System.Windows.Forms.TextBox()
        Me.renttxt = New System.Windows.Forms.TextBox()
        Me.rentlbl = New System.Windows.Forms.Label()
        Me.insurtxt = New System.Windows.Forms.TextBox()
        Me.traveltxt = New System.Windows.Forms.TextBox()
        Me.electtxt = New System.Windows.Forms.TextBox()
        Me.insurlbl = New System.Windows.Forms.Label()
        Me.travellbl = New System.Windows.Forms.Label()
        Me.electlbl = New System.Windows.Forms.Label()
        Me.gaslbl = New System.Windows.Forms.Label()
        Me.gastxt = New System.Windows.Forms.TextBox()
        Me.broadtxt = New System.Windows.Forms.TextBox()
        Me.phonetxt = New System.Windows.Forms.TextBox()
        Me.broadlbl = New System.Windows.Forms.Label()
        Me.phonelbl = New System.Windows.Forms.Label()
        Me.accountlbl = New System.Windows.Forms.Label()
        Me.accounttxt = New System.Windows.Forms.TextBox()
        Me.posttxt = New System.Windows.Forms.TextBox()
        Me.printtxt = New System.Windows.Forms.TextBox()
        Me.stocktxt = New System.Windows.Forms.TextBox()
        Me.expensetxt = New System.Windows.Forms.TextBox()
        Me.postlbl = New System.Windows.Forms.Label()
        Me.printlbl = New System.Windows.Forms.Label()
        Me.stocklbl = New System.Windows.Forms.Label()
        Me.fixedtxt = New System.Windows.Forms.TextBox()
        Me.expenslbl = New System.Windows.Forms.Label()
        Me.fixedlbl = New System.Windows.Forms.Label()
        Me.landtxt = New System.Windows.Forms.TextBox()
        Me.landlbl = New System.Windows.Forms.Label()
        Me.saleslbl = New System.Windows.Forms.Label()
        Me.btnCalcu = New System.Windows.Forms.Button()
        Me.Helpbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'incomelbl
        '
        Me.incomelbl.AutoSize = True
        Me.incomelbl.Location = New System.Drawing.Point(129, 22)
        Me.incomelbl.Name = "incomelbl"
        Me.incomelbl.Size = New System.Drawing.Size(42, 13)
        Me.incomelbl.TabIndex = 0
        Me.incomelbl.Text = "Income"
        '
        'expendilbl
        '
        Me.expendilbl.AutoSize = True
        Me.expendilbl.Location = New System.Drawing.Point(507, 22)
        Me.expendilbl.Name = "expendilbl"
        Me.expendilbl.Size = New System.Drawing.Size(63, 13)
        Me.expendilbl.TabIndex = 1
        Me.expendilbl.Text = "Expenditure"
        '
        'salestxt
        '
        Me.salestxt.Location = New System.Drawing.Point(107, 51)
        Me.salestxt.Name = "salestxt"
        Me.salestxt.Size = New System.Drawing.Size(99, 20)
        Me.salestxt.TabIndex = 3
        '
        'renttxt
        '
        Me.renttxt.Location = New System.Drawing.Point(422, 58)
        Me.renttxt.Name = "renttxt"
        Me.renttxt.Size = New System.Drawing.Size(60, 20)
        Me.renttxt.TabIndex = 4
        Me.renttxt.UseSystemPasswordChar = True
        '
        'rentlbl
        '
        Me.rentlbl.AutoSize = True
        Me.rentlbl.Location = New System.Drawing.Point(360, 58)
        Me.rentlbl.Name = "rentlbl"
        Me.rentlbl.Size = New System.Drawing.Size(33, 13)
        Me.rentlbl.TabIndex = 5
        Me.rentlbl.Text = "Rent "
        '
        'insurtxt
        '
        Me.insurtxt.Location = New System.Drawing.Point(422, 85)
        Me.insurtxt.Name = "insurtxt"
        Me.insurtxt.Size = New System.Drawing.Size(60, 20)
        Me.insurtxt.TabIndex = 6
        '
        'traveltxt
        '
        Me.traveltxt.Location = New System.Drawing.Point(422, 112)
        Me.traveltxt.Name = "traveltxt"
        Me.traveltxt.Size = New System.Drawing.Size(60, 20)
        Me.traveltxt.TabIndex = 7
        '
        'electtxt
        '
        Me.electtxt.Location = New System.Drawing.Point(422, 139)
        Me.electtxt.Name = "electtxt"
        Me.electtxt.Size = New System.Drawing.Size(60, 20)
        Me.electtxt.TabIndex = 8
        '
        'insurlbl
        '
        Me.insurlbl.AutoSize = True
        Me.insurlbl.Location = New System.Drawing.Point(349, 85)
        Me.insurlbl.Name = "insurlbl"
        Me.insurlbl.Size = New System.Drawing.Size(54, 13)
        Me.insurlbl.TabIndex = 9
        Me.insurlbl.Text = "Insurance"
        '
        'travellbl
        '
        Me.travellbl.AutoSize = True
        Me.travellbl.Location = New System.Drawing.Point(351, 115)
        Me.travellbl.Name = "travellbl"
        Me.travellbl.Size = New System.Drawing.Size(51, 13)
        Me.travellbl.TabIndex = 10
        Me.travellbl.Text = "Traveling"
        '
        'electlbl
        '
        Me.electlbl.AutoSize = True
        Me.electlbl.Location = New System.Drawing.Point(350, 142)
        Me.electlbl.Name = "electlbl"
        Me.electlbl.Size = New System.Drawing.Size(52, 13)
        Me.electlbl.TabIndex = 11
        Me.electlbl.Text = "Electricity"
        '
        'gaslbl
        '
        Me.gaslbl.AutoSize = True
        Me.gaslbl.Location = New System.Drawing.Point(363, 167)
        Me.gaslbl.Name = "gaslbl"
        Me.gaslbl.Size = New System.Drawing.Size(26, 13)
        Me.gaslbl.TabIndex = 12
        Me.gaslbl.Text = "Gas"
        '
        'gastxt
        '
        Me.gastxt.Location = New System.Drawing.Point(422, 165)
        Me.gastxt.Name = "gastxt"
        Me.gastxt.Size = New System.Drawing.Size(60, 20)
        Me.gastxt.TabIndex = 13
        '
        'broadtxt
        '
        Me.broadtxt.Location = New System.Drawing.Point(422, 192)
        Me.broadtxt.Name = "broadtxt"
        Me.broadtxt.Size = New System.Drawing.Size(60, 20)
        Me.broadtxt.TabIndex = 14
        '
        'phonetxt
        '
        Me.phonetxt.Location = New System.Drawing.Point(422, 219)
        Me.phonetxt.Name = "phonetxt"
        Me.phonetxt.Size = New System.Drawing.Size(60, 20)
        Me.phonetxt.TabIndex = 15
        '
        'broadlbl
        '
        Me.broadlbl.AutoSize = True
        Me.broadlbl.Location = New System.Drawing.Point(347, 192)
        Me.broadlbl.Name = "broadlbl"
        Me.broadlbl.Size = New System.Drawing.Size(59, 13)
        Me.broadlbl.TabIndex = 16
        Me.broadlbl.Text = "Broadband"
        '
        'phonelbl
        '
        Me.phonelbl.AutoSize = True
        Me.phonelbl.Location = New System.Drawing.Point(357, 222)
        Me.phonelbl.Name = "phonelbl"
        Me.phonelbl.Size = New System.Drawing.Size(38, 13)
        Me.phonelbl.TabIndex = 17
        Me.phonelbl.Text = "Phone"
        '
        'accountlbl
        '
        Me.accountlbl.AutoSize = True
        Me.accountlbl.Location = New System.Drawing.Point(507, 58)
        Me.accountlbl.Name = "accountlbl"
        Me.accountlbl.Size = New System.Drawing.Size(80, 13)
        Me.accountlbl.TabIndex = 18
        Me.accountlbl.Text = "Accountant fee"
        '
        'accounttxt
        '
        Me.accounttxt.Location = New System.Drawing.Point(618, 54)
        Me.accounttxt.Name = "accounttxt"
        Me.accounttxt.Size = New System.Drawing.Size(61, 20)
        Me.accounttxt.TabIndex = 19
        '
        'posttxt
        '
        Me.posttxt.Location = New System.Drawing.Point(618, 81)
        Me.posttxt.Name = "posttxt"
        Me.posttxt.Size = New System.Drawing.Size(61, 20)
        Me.posttxt.TabIndex = 20
        '
        'printtxt
        '
        Me.printtxt.Location = New System.Drawing.Point(618, 109)
        Me.printtxt.Name = "printtxt"
        Me.printtxt.Size = New System.Drawing.Size(61, 20)
        Me.printtxt.TabIndex = 21
        '
        'stocktxt
        '
        Me.stocktxt.Location = New System.Drawing.Point(618, 135)
        Me.stocktxt.Name = "stocktxt"
        Me.stocktxt.Size = New System.Drawing.Size(61, 20)
        Me.stocktxt.TabIndex = 22
        '
        'expensetxt
        '
        Me.expensetxt.Location = New System.Drawing.Point(618, 161)
        Me.expensetxt.Name = "expensetxt"
        Me.expensetxt.Size = New System.Drawing.Size(61, 20)
        Me.expensetxt.TabIndex = 23
        '
        'postlbl
        '
        Me.postlbl.AutoSize = True
        Me.postlbl.Location = New System.Drawing.Point(524, 85)
        Me.postlbl.Name = "postlbl"
        Me.postlbl.Size = New System.Drawing.Size(46, 13)
        Me.postlbl.TabIndex = 24
        Me.postlbl.Text = "Postage"
        '
        'printlbl
        '
        Me.printlbl.AutoSize = True
        Me.printlbl.Location = New System.Drawing.Point(498, 110)
        Me.printlbl.Name = "printlbl"
        Me.printlbl.Size = New System.Drawing.Size(99, 13)
        Me.printlbl.TabIndex = 25
        Me.printlbl.Text = "Print and Stationery"
        '
        'stocklbl
        '
        Me.stocklbl.AutoSize = True
        Me.stocklbl.Location = New System.Drawing.Point(530, 139)
        Me.stocklbl.Name = "stocklbl"
        Me.stocklbl.Size = New System.Drawing.Size(35, 13)
        Me.stocklbl.TabIndex = 26
        Me.stocklbl.Text = "Stock"
        '
        'fixedtxt
        '
        Me.fixedtxt.Location = New System.Drawing.Point(618, 189)
        Me.fixedtxt.Name = "fixedtxt"
        Me.fixedtxt.Size = New System.Drawing.Size(61, 20)
        Me.fixedtxt.TabIndex = 27
        '
        'expenslbl
        '
        Me.expenslbl.AutoSize = True
        Me.expenslbl.Location = New System.Drawing.Point(521, 167)
        Me.expenslbl.Name = "expenslbl"
        Me.expenslbl.Size = New System.Drawing.Size(53, 13)
        Me.expenslbl.TabIndex = 28
        Me.expenslbl.Text = "Expenses"
        '
        'fixedlbl
        '
        Me.fixedlbl.AutoSize = True
        Me.fixedlbl.Location = New System.Drawing.Point(483, 192)
        Me.fixedlbl.Name = "fixedlbl"
        Me.fixedlbl.Size = New System.Drawing.Size(129, 13)
        Me.fixedlbl.TabIndex = 29
        Me.fixedlbl.Text = "Fixed Assets Depreciation"
        '
        'landtxt
        '
        Me.landtxt.Location = New System.Drawing.Point(618, 215)
        Me.landtxt.Name = "landtxt"
        Me.landtxt.Size = New System.Drawing.Size(61, 20)
        Me.landtxt.TabIndex = 30
        '
        'landlbl
        '
        Me.landlbl.AutoSize = True
        Me.landlbl.Location = New System.Drawing.Point(515, 215)
        Me.landlbl.Name = "landlbl"
        Me.landlbl.Size = New System.Drawing.Size(65, 13)
        Me.landlbl.TabIndex = 31
        Me.landlbl.Text = "Land Phone"
        '
        'saleslbl
        '
        Me.saleslbl.AutoSize = True
        Me.saleslbl.Location = New System.Drawing.Point(51, 54)
        Me.saleslbl.Name = "saleslbl"
        Me.saleslbl.Size = New System.Drawing.Size(36, 13)
        Me.saleslbl.TabIndex = 32
        Me.saleslbl.Text = "Sales "
        '
        'btnCalcu
        '
        Me.btnCalcu.Location = New System.Drawing.Point(638, 250)
        Me.btnCalcu.Name = "btnCalcu"
        Me.btnCalcu.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcu.TabIndex = 33
        Me.btnCalcu.Text = "Calculate"
        Me.btnCalcu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCalcu.UseVisualStyleBackColor = True
        '
        'Helpbtn
        '
        Me.Helpbtn.Location = New System.Drawing.Point(557, 249)
        Me.Helpbtn.Name = "Helpbtn"
        Me.Helpbtn.Size = New System.Drawing.Size(75, 23)
        Me.Helpbtn.TabIndex = 34
        Me.Helpbtn.Text = "Help"
        Me.Helpbtn.UseVisualStyleBackColor = True
        '
        'frmdataentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 285)
        Me.Controls.Add(Me.Helpbtn)
        Me.Controls.Add(Me.btnCalcu)
        Me.Controls.Add(Me.saleslbl)
        Me.Controls.Add(Me.landlbl)
        Me.Controls.Add(Me.landtxt)
        Me.Controls.Add(Me.fixedlbl)
        Me.Controls.Add(Me.expenslbl)
        Me.Controls.Add(Me.fixedtxt)
        Me.Controls.Add(Me.stocklbl)
        Me.Controls.Add(Me.printlbl)
        Me.Controls.Add(Me.postlbl)
        Me.Controls.Add(Me.expensetxt)
        Me.Controls.Add(Me.stocktxt)
        Me.Controls.Add(Me.printtxt)
        Me.Controls.Add(Me.posttxt)
        Me.Controls.Add(Me.accounttxt)
        Me.Controls.Add(Me.accountlbl)
        Me.Controls.Add(Me.phonelbl)
        Me.Controls.Add(Me.broadlbl)
        Me.Controls.Add(Me.phonetxt)
        Me.Controls.Add(Me.broadtxt)
        Me.Controls.Add(Me.gastxt)
        Me.Controls.Add(Me.gaslbl)
        Me.Controls.Add(Me.electlbl)
        Me.Controls.Add(Me.travellbl)
        Me.Controls.Add(Me.insurlbl)
        Me.Controls.Add(Me.electtxt)
        Me.Controls.Add(Me.traveltxt)
        Me.Controls.Add(Me.insurtxt)
        Me.Controls.Add(Me.rentlbl)
        Me.Controls.Add(Me.renttxt)
        Me.Controls.Add(Me.salestxt)
        Me.Controls.Add(Me.expendilbl)
        Me.Controls.Add(Me.incomelbl)
        Me.Name = "frmdataentry"
        Me.Text = "Data Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents incomelbl As Label
    Friend WithEvents expendilbl As Label
    Friend WithEvents salestxt As TextBox
    Friend WithEvents renttxt As TextBox
    Friend WithEvents rentlbl As Label
    Friend WithEvents insurtxt As TextBox
    Friend WithEvents traveltxt As TextBox
    Friend WithEvents electtxt As TextBox
    Friend WithEvents insurlbl As Label
    Friend WithEvents travellbl As Label
    Friend WithEvents electlbl As Label
    Friend WithEvents gaslbl As Label
    Friend WithEvents gastxt As TextBox
    Friend WithEvents broadtxt As TextBox
    Friend WithEvents phonetxt As TextBox
    Friend WithEvents broadlbl As Label
    Friend WithEvents phonelbl As Label
    Friend WithEvents accountlbl As Label
    Friend WithEvents accounttxt As TextBox
    Friend WithEvents posttxt As TextBox
    Friend WithEvents printtxt As TextBox
    Friend WithEvents stocktxt As TextBox
    Friend WithEvents expensetxt As TextBox
    Friend WithEvents postlbl As Label
    Friend WithEvents printlbl As Label
    Friend WithEvents stocklbl As Label
    Friend WithEvents fixedtxt As TextBox
    Friend WithEvents expenslbl As Label
    Friend WithEvents fixedlbl As Label
    Friend WithEvents landtxt As TextBox
    Friend WithEvents landlbl As Label
    Friend WithEvents saleslbl As Label
    Friend WithEvents btnCalcu As Button
    Friend WithEvents Helpbtn As Button
End Class

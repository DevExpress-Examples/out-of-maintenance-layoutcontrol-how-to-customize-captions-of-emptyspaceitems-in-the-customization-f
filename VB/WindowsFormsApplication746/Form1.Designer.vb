Namespace WindowsFormsApplication746
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.textEdit1)
            Me.layoutControl1.Controls.Add(Me.buttonEdit1)
            Me.layoutControl1.Controls.Add(Me.simpleButton1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2735, 147, 410, 434)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(487, 255)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.layoutControlItem3, Me.emptySpaceItem3, Me.emptySpaceItem4})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(487, 255)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(12, 36)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(161, 22)
            Me.simpleButton1.StyleController = Me.layoutControl1
            Me.simpleButton1.TabIndex = 4
            Me.simpleButton1.Text = "simpleButton1"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.simpleButton1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(165, 26)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' buttonEdit1
            ' 
            Me.buttonEdit1.Location = New System.Drawing.Point(423, 36)
            Me.buttonEdit1.Name = "buttonEdit1"
            Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.buttonEdit1.Size = New System.Drawing.Size(52, 20)
            Me.buttonEdit1.StyleController = Me.layoutControl1
            Me.buttonEdit1.TabIndex = 5
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.buttonEdit1
            Me.layoutControlItem2.Location = New System.Drawing.Point(314, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(153, 24)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(93, 13)
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.Location = New System.Drawing.Point(109, 12)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Size = New System.Drawing.Size(132, 20)
            Me.textEdit1.StyleController = Me.layoutControl1
            Me.textEdit1.TabIndex = 6
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.textEdit1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(233, 24)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(93, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(233, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(234, 24)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(165, 24)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(149, 211)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 50)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(165, 185)
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.AllowHotTrack = False
            Me.emptySpaceItem4.Location = New System.Drawing.Point(314, 48)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(153, 187)
            Me.emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(487, 255)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private textEdit1 As DevExpress.XtraEditors.TextEdit
        Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
        Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace


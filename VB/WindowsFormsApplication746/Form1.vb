Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Customization.Controls

Namespace WindowsFormsApplication746
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            AddHandler layoutControl1.ShowCustomization, AddressOf layoutControl1_ShowCustomization
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            layoutControl1.ShowCustomizationForm()
        End Sub

        Private Sub layoutControl1_ShowCustomization(ByVal sender As Object, ByVal e As EventArgs)
            Dim group As TabbedControlGroup = GetCustomizationWindowTabbedControlGroup(TryCast(sender, LayoutControl))
            If group IsNot Nothing Then
                AddHandler group.SelectedPageChanged, AddressOf group_SelectedPageChanged
            End If
            group.SelectedTabPageIndex = 1 'for this example only. Remove this code in your application
        End Sub

        Private Function GetCustomizationWindowTabbedControlGroup(ByVal layoutControl As LayoutControl) As TabbedControlGroup
            Dim lcControls = layoutControl.CustomizationForm.Controls.OfType(Of LayoutControl)().ToArray()
            If lcControls.Count() = 0 Then
                Return Nothing
            End If
            Dim tcgControls = lcControls(0).Items.OfType(Of TabbedControlGroup)().ToArray()
            If tcgControls.Count() = 0 Then
                Return Nothing
            End If
            Return tcgControls(0)
        End Function

        Private Sub group_SelectedPageChanged(ByVal sender As Object, ByVal e As LayoutTabPageChangedEventArgs)
            Dim layoutControlItem As LayoutControlItem = TryCast(e.Page.Items(0), LayoutControlItem)
            Dim tree As LayoutTreeView = TryCast(layoutControlItem.Control, LayoutTreeView)
            If tree Is Nothing Then
                Return
            End If
            For Each item As BaseLayoutItemTreeNode In tree.Nodes(0).Nodes
                Dim esItem As EmptySpaceItem = TryCast((TryCast(item, BaseLayoutItemTreeNode)).Item, EmptySpaceItem)
                If esItem IsNot Nothing Then
                    item.Text = """" & esItem.CustomizationFormText & """" 'customize captions here
                End If
            Next item
        End Sub
    End Class
End Namespace

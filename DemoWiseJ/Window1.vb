Imports System
Imports Wisej.Web

Public Class EnergyCounterApp
    Dim energyCount As Integer = 0
    Dim tails = New Integer() {1, 1, 1}
    Dim backs = New Integer() {1, 1, 1}
    Dim horns = New Integer() {1, 1, 1}
    Dim mouths = New Integer() {1, 1, 1}
    Dim tailCount = New Integer() {0, 0, 0}
    Dim backCount = New Integer() {0, 0, 0}
    Dim hornCount = New Integer() {0, 0, 0}
    Dim mouthCount = New Integer() {0, 0, 0}
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Shape1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles plusBtn.Click

        energyCount += 1
        energyText.Text = energyCount.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles minusBtn.Click
        energyCount -= 1
        If energyCount <= 0 Then
            energyCount = 0
        End If
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles backCost1.CheckedChanged
        If backCost1.Checked = True Then
            backs(0) = 0
        Else
            backs(0) = 1
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles deadBtn1.Click
        tailBtn1.Enabled = False
        tailBtnMin1.Enabled = False
        mouthBtnMin1.Enabled = False
        mouthBtn1.Enabled = False
        backBtn1.Enabled = False
        backBtnMin1.Enabled = False
        hornBtn1.Enabled = False
        hornBtnMin1.Enabled = False
        hornCost1.Enabled = False
        tailCost1.Enabled = False
        backCost1.Enabled = False
        mouthCost1.Enabled = False
    End Sub

    Private Sub backBtn1_Click(sender As Object, e As EventArgs) Handles backBtn1.Click
        backCount(0) += 1
        backCount1.Text = backCount(0).ToString
        energyCount += backs(0)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles mouthCost1.CheckedChanged
        If mouthCost1.Checked = True Then
            mouths(0) = 0
        Else
            mouths(0) = 1
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles hornCost1.CheckedChanged
        If hornCost1.Checked = True Then
            horns(0) = 0
        Else
            horns(0) = 1
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles tailCost1.CheckedChanged
        If tailCost1.Checked = True Then
            tails(0) = 0
        Else
            tails(0) = 1
        End If
    End Sub

    Private Sub mountBtn1_Click(sender As Object, e As EventArgs) Handles mouthBtn1.Click
        mouthCount(0) += 1
        mouthCount1.Text = mouthCount(0).ToString
        energyCount += mouths(0)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub hornBtn1_Click(sender As Object, e As EventArgs) Handles hornBtn1.Click
        hornCount(0) += 1
        hornCount1.Text = hornCount(0).ToString
        energyCount += horns(0)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub tailBtn1_Click(sender As Object, e As EventArgs) Handles tailBtn1.Click
        tailCount(0) += 1
        tailCount1.Text = tailCount(0).ToString
        energyCount += tails(0)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub backBtn2_Click(sender As Object, e As EventArgs) Handles backBtn2.Click
        backCount(1) += 1
        backCount2.Text = backCount(1).ToString
        energyCount += backs(1)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub backBtn3_Click(sender As Object, e As EventArgs) Handles backBtn3.Click
        backCount(2) += 1
        backCount3.Text = backCount(2).ToString
        energyCount += backs(2)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles backCost2.CheckedChanged
        If backCost2.Checked = True Then
            backs(1) = 0
        Else
            backs(1) = 1
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles backCost3.CheckedChanged
        If backCost3.Checked = True Then
            backs(2) = 0
        Else
            backs(2) = 1
        End If
    End Sub

    Private Sub mountBtn2_Click(sender As Object, e As EventArgs) Handles mouthBtn2.Click
        mouthCount(1) += 1
        mouthCount2.Text = mouthCount(1).ToString
        energyCount += mouths(1)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub mountBtn3_Click(sender As Object, e As EventArgs) Handles mouthBtn3.Click
        mouthCount(2) += 1
        mouthCount3.Text = mouthCount(2).ToString
        energyCount += mouths(2)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles mouthCost2.CheckedChanged
        If mouthCost2.Checked = True Then
            mouths(1) = 0
        Else
            mouths(1) = 1
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles mouthCost3.CheckedChanged
        If mouthCost3.Checked = True Then
            mouths(2) = 0
        Else
            mouths(2) = 1
        End If
    End Sub

    Private Sub hornBtn2_Click(sender As Object, e As EventArgs) Handles hornBtn2.Click
        hornCount(1) += 1
        hornCount2.Text = hornCount(1).ToString
        energyCount += horns(1)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub hornBtn3_Click(sender As Object, e As EventArgs) Handles hornBtn3.Click
        hornCount(2) += 1
        hornCount3.Text = hornCount(2).ToString
        energyCount += horns(2)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles hornCost2.CheckedChanged
        If hornCost2.Checked = True Then
            horns(1) = 0
        Else
            horns(1) = 1
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles hornCost3.CheckedChanged
        If hornCost3.Checked = True Then
            horns(2) = 0
        Else
            horns(2) = 1
        End If
    End Sub

    Private Sub tailBtn2_Click(sender As Object, e As EventArgs) Handles tailBtn2.Click
        tailCount(1) += 1
        tailCount2.Text = tailCount(1).ToString
        energyCount += tails(1)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub tailBtn3_Click(sender As Object, e As EventArgs) Handles tailBtn3.Click
        tailCount(2) += 1
        tailCount3.Text = tailCount(2).ToString
        energyCount += tails(2)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub Window1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles tailCost2.CheckedChanged
        If tailCost2.Checked = True Then
            tails(1) = 0
        Else
            tails(1) = 1
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles tailCost3.CheckedChanged
        If tailCost3.Checked = True Then
            tails(2) = 0
        Else
            tails(2) = 1
        End If
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles backCount1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles hornBtnMin1.Click
        hornCount(0) -= 1
        hornCount1.Text = hornCount(0).ToString
        energyCount -= horns(0)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles backBtnMin1.Click
        backCount(0) -= 1
        backCount1.Text = backCount(0).ToString
        energyCount -= backs(0)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles mouthBtnMin1.Click
        mouthCount(0) -= 1
        mouthCount1.Text = mouthCount(0).ToString
        energyCount -= mouths(0)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles backBtnMin2.Click
        backCount(1) -= 1
        backCount2.Text = backCount(1).ToString
        energyCount -= backs(1)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles backBtnMin3.Click
        backCount(2) -= 1
        backCount3.Text = backCount(2).ToString
        energyCount -= backs(2)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles mouthBtnMin2.Click
        mouthCount(1) -= 1
        mouthCount2.Text = mouthCount(1).ToString
        energyCount -= mouths(1)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles mouthBtnMin3.Click
        mouthCount(2) -= 1
        mouthCount3.Text = mouthCount(2).ToString
        energyCount -= mouths(2)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles hornBtnMin2.Click
        hornCount(1) -= 1
        hornCount2.Text = hornCount(1).ToString
        energyCount -= horns(1)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles hornBtnMin3.Click
        hornCount(2) -= 1
        hornCount3.Text = hornCount(2).ToString
        energyCount -= horns(2)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles tailBtnMin1.Click
        tailCount(0) -= 1
        tailCount1.Text = tailCount(0).ToString
        energyCount -= tails(0)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles tailBtnMin2.Click
        tailCount(1) -= 1
        tailCount2.Text = tailCount(1).ToString
        energyCount -= tails(1)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles tailBtnMin3.Click
        tailCount(2) -= 1
        tailCount3.Text = tailCount(2).ToString
        energyCount -= tails(2)
        energyText.Text = energyCount.ToString
    End Sub

    Private Sub deadBtn2_Click(sender As Object, e As EventArgs) Handles deadBtn2.Click
        tailBtn2.Enabled = False
        tailBtnMin2.Enabled = False
        mouthBtnMin2.Enabled = False
        mouthBtn2.Enabled = False
        backBtn2.Enabled = False
        backBtnMin2.Enabled = False
        hornBtn2.Enabled = False
        hornBtnMin2.Enabled = False
        hornCost2.Enabled = False
        tailCost2.Enabled = False
        backCost2.Enabled = False
        mouthCost2.Enabled = False
    End Sub

    Private Sub deadBtn3_Click(sender As Object, e As EventArgs) Handles deadBtn3.Click
        tailBtn3.Enabled = False
        tailBtnMin3.Enabled = False
        mouthBtnMin3.Enabled = False
        mouthBtn3.Enabled = False
        backBtn3.Enabled = False
        backBtnMin3.Enabled = False
        hornBtn3.Enabled = False
        hornBtnMin3.Enabled = False
        hornCost3.Enabled = False
        tailCost3.Enabled = False
        backCost3.Enabled = False
        mouthCost3.Enabled = False
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        tailBtn1.Enabled = True
        tailBtnMin1.Enabled = True
        mouthBtnMin1.Enabled = True
        mouthBtn1.Enabled = True
        backBtn1.Enabled = True
        backBtnMin1.Enabled = True
        hornBtn1.Enabled = True
        hornBtnMin1.Enabled = True
        hornCost1.Enabled = True
        tailCost1.Enabled = True
        backCost1.Enabled = True
        mouthCost1.Enabled = True


        tailBtn2.Enabled = True
        tailBtnMin2.Enabled = True
        mouthBtnMin2.Enabled = True
        mouthBtn2.Enabled = True
        backBtn2.Enabled = True
        backBtnMin2.Enabled = True
        hornBtn2.Enabled = True
        hornBtnMin2.Enabled = True
        hornCost2.Enabled = True
        tailCost2.Enabled = True
        backCost2.Enabled = True
        mouthCost2.Enabled = True


        tailBtn3.Enabled = True
        tailBtnMin3.Enabled = True
        mouthBtnMin3.Enabled = True
        mouthBtn3.Enabled = True
        backBtn3.Enabled = True
        backBtnMin3.Enabled = True
        hornBtn3.Enabled = True
        hornBtnMin3.Enabled = True
        hornCost3.Enabled = True
        tailCost3.Enabled = True
        backCost3.Enabled = True
        mouthCost3.Enabled = True

        energyCount = 0
        energyText.Text = energyCount.ToString
        For i As Integer = 0 To 2
            backCount(i) = 0
            mouthCount(i) = 0
            tailCount(i) = 0
            hornCount(i) = 0
        Next
        backCount1.Text = backCount(0).ToString
        backCount2.Text = backCount(1).ToString
        backCount3.Text = backCount(2).ToString
        tailCount1.Text = backCount(0).ToString
        tailCount2.Text = backCount(1).ToString
        tailCount3.Text = backCount(2).ToString
        mouthCount1.Text = backCount(0).ToString
        mouthCount2.Text = backCount(1).ToString
        mouthCount3.Text = backCount(2).ToString
        hornCount1.Text = backCount(0).ToString
        hornCount2.Text = backCount(1).ToString
        hornCount3.Text = backCount(2).ToString
    End Sub
End Class

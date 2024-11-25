Imports System.Web.UI.WebControls
Imports Org.BouncyCastle.Asn1.Cmp

Public Class Form1
    Public Class Form1
        ' Define the maximum number of books allowed
        Private Const MAX_BOOKS As Integer = 100

        ' Private variables for book information
        Private bookList As New List(Of Book)()

        ' Book structure to hold book data
        Private Structure Book
            Dim Title As String
            Dim Author As String
            Dim Genre As String
            Dim Status As String
        End Structure

        Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
            ' Check if maximum number of books is reached
            If bookList.Count >= MAX_BOOKS Then
                MessageBox.Show("Maximum number of books reached.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Create a new book instance
            Dim newBook As New Book()

            ' Assign values to the book from input fields
            newBook.Title = titleTxtbox.Text ' TextBox for book title

            ' Validate Title
            If String.IsNullOrWhiteSpace(newBook.Title) Then
                MessageBox.Show("Please enter a title.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Assign Author
            newBook.Author = authorTxtbox.Text ' TextBox for book author

            ' Validate Author
            If String.IsNullOrWhiteSpace(newBook.Author) Then
                MessageBox.Show("Please enter an author.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Assign Genre
            newBook.Genre = genreTxtbox.Text ' TextBox for book genre

            ' Validate Genre
            If String.IsNullOrWhiteSpace(newBook.Genre) Then
                MessageBox.Show("Please enter a genre.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Assign Status
            newBook.Status = bookStatus.SelectedItem.ToString() ' ComboBox for book status

            ' Validate Status
            If String.IsNullOrWhiteSpace(newBook.Status) Then
                MessageBox.Show("Please select a status.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Add the new book to the list and display in the DataGridView
            bookList.Add(newBook)
            DataGridView1.Rows.Add(newBook.Title, newBook.Author, newBook.Genre, newBook.Status)

            ' Update the total books released label
            UpdateTotalBooksReleased()

            ' Clear input fields after adding the book
            ClearFields()
        End Sub

        Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
            ' Check if a row is selected in the DataGridView
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Retrieve the selected book information
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                bookTitle.Text = selectedRow.Cells(0).Value.ToString() ' Display Title
                bookAuthor.Text = selectedRow.Cells(1).Value.ToString() ' Display Author
                bookGenre.Text = selectedRow.Cells(2).Value.ToString() ' Display Genre
                ComboBox2.Text = selectedRow.Cells(3).Value.ToString() ' Display Status
            Else
                ' Show a message if no row is selected
                MessageBox.Show("Please select a book from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
            ' Check if a row is selected in the DataGridView
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Retrieve the selected book information
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                selectedRow.Cells(0).Value = bookTitle.Text ' Update Title
                selectedRow.Cells(1).Value = bookAuthor.Text ' Update Author
                selectedRow.Cells(2).Value = bookGenre.Text ' Update Genre
                selectedRow.Cells(3).Value = ComboBox2.Text ' Update Status
            Else
                ' Show a message if no row is selected
                MessageBox.Show("Please select a book from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
            ' Clear the input fields and ComboBox
            ClearFields()
        End Sub

        Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
            ' Check if there are any rows in the DataGridView
            If DataGridView1.Rows.Count > 0 Then
                ' Remove the first row from the DataGridView and the list
                bookList.RemoveAt(0)
                DataGridView1.Rows.RemoveAt(0)

                ' Update the total books released label
                UpdateTotalBooksReleased()
            Else
                ' Show a message if there are no rows to delete
                MessageBox.Show("No items to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        ' Method to clear all fields
        Private Sub ClearFields()
            titleTxtbox.Clear() ' Clear the book title textbox
            authorTxtbox.Clear() ' Clear the book author textbox
            genreTxtbox.Clear() ' Clear the book genre textbox
            bookTitle.Clear() ' Clear the TextBox for displaying book info
            bookAuthor.Clear() ' Clear the TextBox for displaying book info
            bookGenre.Clear() ' Clear the TextBox for displaying book info
            ComboBox2.Clear() ' Clear the TextBox for displaying status
            bookStatus.SelectedIndex = -1 ' Clear the ComboBox selection
        End Sub

        ' Method to update the total books released label
        Private Sub UpdateTotalBooksReleased()
            lblTotalBooks.Text = $"Total Books Released: {bookList.Count}/{MAX_BOOKS}"
        End Sub
    End Class


End Class

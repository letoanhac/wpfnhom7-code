using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace btl
{
    public partial class PreviewWindow : Window
    {
        public PreviewWindow()
        {
            InitializeComponent();
        }

        public void SetInvoice(UserControl invoiceControl)
        {
            // Đặt nội dung của hóa đơn vào khu vực hiển thị
            InvoicePreview.Content = invoiceControl;
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            // Tạo đối tượng PrintDialog để in
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == true)
            {
                // Chuẩn bị UserControl để in
                var invoiceVisual = InvoicePreview.Content as UserControl;
                if (invoiceVisual != null)
                {
                    invoiceVisual.Measure(new Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight));
                    invoiceVisual.Arrange(new Rect(new Point(0, 0), invoiceVisual.DesiredSize));

                    // In hóa đơn
                    printDialog.PrintVisual(invoiceVisual, "Hóa đơn");
                }
            }
        }
    }
}
using System;
using UIKit;
using Foundation;
using System.Text;
using System.Collections.Generic;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		//BarcodeDelegate rcpDelegate;
		RcpRfidDelegate rfidDelegate;
		//static RcpBarcodeApi rcp;
		static RcpRfidApi rcpRfid;
        static List<string> lecturas;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//rcp = new RcpBarcodeApi ();
			//rcpDelegate = new BarcodeDelegate(this);
			//rcp.WeakDelegate = rcpDelegate;
			//rcp.SetReaderPower (true);

			rcpRfid = new RcpRfidApi ();
			rfidDelegate = new RfidDelegate (this);
			rcpRfid.WeakDelegate = rfidDelegate;
			rcpRfid.SetReaderPower (true);

            lecturas = new List<string>();

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}
			
		partial void ReadButton_TouchUpInside (UIButton sender)
		{
			new System.Threading.Thread(new System.Threading.ThreadStart(() => {
				InvokeOnMainThread (() => {
					//rcp.StartReadBarcodes(0x00,0x00,0x00);
					rcpRfid.StartReadTags(0x00,0x00,0x00);
				});
			})).Start();				
		}

		partial void StopButton_TouchUpInside (UIButton sender)
		{
			//var status = rcp.StopReadBarcodes();
			var status = rcpRfid.StopReadTags();
		}

		partial void ClearButton_TouchUpInside (UIButton sender)
		{
			ReadText.Text = "";
		}			
	
		//public class BarcodeDelegate : RcpBarcodeDelegate
		//{
		//	WeakReference viewController;
		//	ViewController ViewController {
		//		get { 
		//			return viewController == null ? null : (ViewController) viewController.Target;
		//		}

		//		set {
		//			viewController = value == null ? null : new WeakReference (value);
		//		}
		//	}

		//	public BarcodeDelegate (ViewController viewController) : base()
		//	{
		//		this.ViewController = viewController;
		//	}

		//	public override void PluggedBarcode (bool plug)
		//	{
		//		if (rcp.Open()) {
		//			rcp.SetReaderPower (true);
		//		}
		//	}
				
		//	public override void BarcodeStringReceived (string barcode)
		//	{

		//		InvokeOnMainThread ( () => {
		//			this.ViewController.ReadText.Text = this.ViewController.ReadText.Text + "\n" + barcode;
		//		});
		//	}
		//}

		public class RfidDelegate : RcpRfidDelegate
		{		
			WeakReference viewController;
			ViewController ViewController {
				get { 
					return viewController == null ? null : (ViewController) viewController.Target;
				}

				set {
					viewController = value == null ? null : new WeakReference (value);
				}
			}

			public RfidDelegate (ViewController viewController) : base()
			{
				this.ViewController = viewController;
			}
				
			public override void PluggedRfid (bool plug)
			{
				InvokeOnMainThread ( () => {
					if (plug == true) {	
						this.ViewController.StatusLabel.Text = "Plugged";
						if (rcpRfid.Open()) {
							rcpRfid.SetReaderPower (true);
						}
					}else{
						this.ViewController.StatusLabel.Text = "UnPlugged";
					}
				});
			}

			public override void EpcReceived (Foundation.NSData epc)
			{
				InvokeOnMainThread ( () => {
					
					var builder = new StringBuilder();
					var buffer = epc.Bytes;
					var bytes = new byte[epc.Length];
					System.Runtime.InteropServices.Marshal.Copy(buffer, bytes, 0, bytes.Length);

					for(UInt32 i = 0; i < bytes.Length; i++)												
						builder.Append(bytes[i].ToString("x2"));

					this.ViewController.ReadText.Text = this.ViewController.ReadText.Text + "\n" + builder.ToString();

                    lecturas.Add(string.Format("{0} - {1}", builder.ToString(), DateTime.Now.ToLongDateString()));
                    this.ViewController.DataTableView.Source = new DataTableSource(lecturas);
                    this.ViewController.DataTableView.ReloadData();
				});
			}
		}

	}

    internal class DataTableSource : UITableViewSource
    {
        private List<string> lecturas;
        private string cellIdentifier = "TableCell";

        public DataTableSource(List<string> lecturas)
        {
            this.lecturas = lecturas;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(cellIdentifier);
            string item = lecturas[indexPath.Row];

            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
                cell.TextLabel.Text = item;
            }

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return lecturas.Count;
        }
    }
}


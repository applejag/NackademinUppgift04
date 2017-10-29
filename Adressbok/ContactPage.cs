using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Adressbok.Models;

namespace Adressbok
{
	public partial class ContactPage : Form
	{
		public ContactPage(DataTable personer, int row)
		{
			InitializeComponent();
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Database;

namespace app.Presentation
{
    public partial class UserUC : UserControl
    {
        private readonly AppDbContext _dbContext;
        
        public UserUC()
        {
            InitializeComponent();
            InitializeUserService();
        }

        public void InitializeUserService()
        {

        }
    }
}

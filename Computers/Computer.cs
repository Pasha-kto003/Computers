using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class Computer
    {
        public int IP { get; set; }
        public int MacAdress { get; set; }
        public int InventoryNumber { get; set; }
        public string DomenName { get; set; }
        public int GroupID { get; set; }
        //[NotMapped]
        //public Group GroupName 
        //{
        //    get
        //    {
        //        return GetGroup(GroupID);
        //    }
        //}
        //public Group GetGroup(int id)
        //{
        //    Group group = 
        //}
    }
}

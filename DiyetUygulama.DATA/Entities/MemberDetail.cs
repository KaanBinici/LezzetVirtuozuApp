using DiyetUygulama.DATA.Abstracts;
using DiyetUygulama.DATA.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DATA.Entities
{
    public class MemberDetail : BaseEntity
    {

        private DateTime _birthDate;


        public int MemberDetailId { get; set; }
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        [NotMapped]
        public int Age
        {
            get { return DateTime.Now.Year - _birthDate.Year; }
        }

        public bool? Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double? FatRatio { get; set; }
        public bool IsDiabetes { get; set; }
        public Allergies? Allergy1 { get; set; }    //Nullable olacak
        public Allergies? Allergy2 { get; set; }    //Nullable olacak

        //Navigation Properties
        public int MemberId { get; set; }
        public Member Member { get; set; }

    }
}

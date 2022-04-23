using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THITN
{
    class InfoExam
    {
        public String maMH { get; set; }
        public String maLop { get; set; }
        public String trinhDo { get; set; }
        public DateTime ngayThi { get; set; }
        public int lan { get; set; }
        public int soCauThi { get; set; }
        public int thoiGian { get; set; }

        public List<QuestionExam> questionExams { get; set; }
    }
}

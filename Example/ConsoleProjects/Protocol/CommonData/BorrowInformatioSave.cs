﻿
using System.Collections.Generic;

namespace Protocol.CommonData
{
    [System.Serializable]
    public class BorrowInformatioSave:NetMsg
    {
        public List<BorrowInformatio> borrows = new List<BorrowInformatio>();
    }
}

using Verse;

namespace ImprovedWorkbenches
{
    public class Dialog_RenameBill : Dialog_Rename<IRenameable>
    {
        private readonly ExtendedBillData _extendedBill;

        //private readonly string _currentName;

        //public Dialog_RenameBill(ExtendedBillData extendedBill, string currentName)
        //{
        //    _extendedBill = extendedBill;
        //    _currentName = currentName;
        //    curName = currentName;
        //}

        public Dialog_RenameBill(ExtendedBillData extendedBill) : base(null)
        {
            _extendedBill = extendedBill;
        }

        protected override void OnRenamed(string name)
        {
            _extendedBill.Name = name;
        }

        //public override void SetName(string name)
        //{
        //    if (string.IsNullOrEmpty(name) || name != _currentName)
        //        _extendedBill.Name = name;
        //}

        //public override AcceptanceReport NameIsValid(string name)
        //{
        //    return true;
        //}
    }
}
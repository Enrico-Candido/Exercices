namespace ExHerancaPolimorfismo2.Entities {
    sealed class ImportedProduct : Product {
        public double CustomsFee { get; set; }
        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customFee) : base(name, price) {
            CustomsFee = customFee;
        }
        public double TotalPrice() {
            return Price + CustomsFee;
        }
        public override string PriceTag() {
            return $"{Name} $ {TotalPrice():F2} (Customs fee: $ {CustomsFee:F2})";
        }
    }
}

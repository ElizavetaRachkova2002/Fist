namespace ProductsAndPackages
{
    public class Package
    {
        private string _name_package;
        public string Size { get; set; }
        public bool IsSelected { get; set; }
        private int _count_package;
        public string Name_package
        {
            get { return _name_package; }
            set
            {
                _name_package = value;

            }
        }
        public int Count_package
        {
            get { return _count_package; }
            set
            {
                _count_package = value;


            }
        }
        public Package() { }
        public Package(string name, string size, int count)
        {
            Name_package = name;
            Size = size;
            Count_package = count;
            IsSelected = false;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", Name_package, Size);
        }
    }
}

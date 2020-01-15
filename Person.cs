namespace Labs2
{
    class Person
    {
        const int Child_Max = 10;
        string fam = "", status = "", health = "";
        int age = 0, salary = 0;
        public int count_children = 0;
        Person[] children = new Person[Child_Max];
        public string Fam
        {
            set { if (fam == "") fam = value; }
            get { return (fam); }
        }
        public string Status
        {
            get { return (status); }
        }
        public int Age
        {
            set
            {
                age = value;
                if (age < 7) status = "ребенок";
                else if (age < 17) status = "школьник";
                else if (age < 22) status = "студент";
                else status = "служащий";
            }
            get { return (age); }
        }
        public int Salary
        {
            set { salary = value; }
        }
        public Person this[int i]
        {
            get
            {
                if (i >= 0 && i < count_children) return (children[i]);
                else return (children[0]);
            }
            set
            {
                if (i == count_children && i < Child_Max)
                {
                    children[i] = value; count_children++;
                }
            }
        }
    }
}

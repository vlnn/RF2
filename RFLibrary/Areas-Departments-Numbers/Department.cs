namespace RF {
    public enum Cities {
        Kyiv,
        Kharkiv,
        Dnipro,
        Lviv,
        Odesa
    }

    public class Department : Region {

        public override string Area() {
            return("Main Dept");
        }
    }
}

namespace RF {
    enum Areas {
        North,
        East,
        South,
        West
    }

    public class AreaOfRegion : Region {    

        public override string Area() {
            return Areas.North.ToString();
        }
    }
}

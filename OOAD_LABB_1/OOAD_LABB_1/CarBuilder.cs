using OOAD_LABB_1;

public interface BrandCarBuilder
{
    NumberOfDoorsCarBuilder SetBrand(Brand brand);
}

public interface NumberOfDoorsCarBuilder
{
    OptionalValueCarBuilder SetNumberOfDoors(int numberOfDoors);
}

public interface OptionalValueCarBuilder
{
    OptionalValueCarBuilder SetIsConvertible(bool isConvertible);
    OptionalValueCarBuilder SetHasSunRoof(bool hasSunRoof);
    OptionalValueCarBuilder SetColor(string color);
    Car Build();
}

public class Car
{
    private Brand brand;
    private int numberOfDoors;
    public bool isConvertible { get; set; }
    public bool hasSunRoof { get; set; }
    public string color { get; set; }
    private Car() {}
    private Car(Brand brand, int numberOfDoors, bool isConvertible, bool hasSunRoof, string color)
    {
        this.brand = brand;
        this.numberOfDoors = numberOfDoors;
        this.isConvertible = isConvertible;
        this.hasSunRoof = hasSunRoof;
        this.color = color;
    }

    public override string ToString()
    {
        return $"Brand: {brand}\nIsConvertible: {isConvertible}\n" +
            $"HasSunRoof: {hasSunRoof}\nNumberOfDoors: {numberOfDoors}\n" +
            $"Color: {color}";
    }

    public class Builder : BrandCarBuilder, NumberOfDoorsCarBuilder, OptionalValueCarBuilder
    {
        private Brand brand;
        private int numberOfDoors;
        private bool isConvertible;
        private bool hasSunRoof;
        private string color;

        private Builder()
        {
            //Setting defaults to optional values
            isConvertible = false;
            hasSunRoof = false;
            color = "gray";
        }

        public static BrandCarBuilder Start()
        {
            return new Builder();
        }

        public NumberOfDoorsCarBuilder SetBrand(Brand brand)
        {
            this.brand = brand;
            return this;
        }

        public OptionalValueCarBuilder SetNumberOfDoors(int numberOfDoors)
        {
            this.numberOfDoors = numberOfDoors;
            return this;
        }

        public OptionalValueCarBuilder SetIsConvertible(bool isConvertible)
        {
            this.isConvertible = isConvertible;
            return this;
        }

        public OptionalValueCarBuilder SetHasSunRoof(bool hasSunRoof)
        {
            this.hasSunRoof = hasSunRoof;
            return this;
        }

        public OptionalValueCarBuilder SetColor(string color)
        {
            this.color = color;
            return this;
        }

        public Car Build()
        {
            return new Car(brand, numberOfDoors, isConvertible, hasSunRoof, color);
        }
    }

}




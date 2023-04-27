using gostayapp1.Models;


namespace gostayapp1.Data
{
    public static class SelectNation
    {
        public static IList<Animal> Nation { get; private set; }

        static SelectNation()
        {
            Nation = new List<Animal>();

            Nation.Add(new Animal
            {
                Name = "Afghanistan",
            });

            Nation.Add(new Animal
            {
                Name = "Albania",
            });

            Nation.Add(new Animal
            {
                Name = "Algeria",
            });

            Nation.Add(new Animal
            {
                Name = "American Samoa",
            });

            Nation.Add(new Animal
            {
                Name = "Andorra",
            });

            Nation.Add(new Animal
            {
                Name = "Anguilla",
            });

            Nation.Add(new Animal
            {
                Name = "Antarctica",
            });

            Nation.Add(new Animal
            {
                Name = "Antigua and Barbuda",
            });

            Nation.Add(new Animal
            {
                Name = "Argentina",
            });

            Nation.Add(new Animal
            {
                Name = "Armenia",
            });

            Nation.Add(new Animal
            {
                Name = "Aruba",
            });
        }
    }
}
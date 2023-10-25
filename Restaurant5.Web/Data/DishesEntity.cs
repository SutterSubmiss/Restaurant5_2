namespace Restaurant5.Web.Data
{
    public class DishesEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image_file { get; set; }
        public int Stars { get; set; }
        public ICollection<DishesEntity> Dishes { get; set; }
        public DishesEntity()
        {
        

        }
    }
}

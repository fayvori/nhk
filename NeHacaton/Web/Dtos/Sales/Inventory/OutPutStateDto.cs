namespace Web.Dtos.Sales.Inventory
{
    public class OutputStateDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? @Const { get; set; }
        public string? TextColor { get; set; }
        public string? Color { get; set; }
    }

}

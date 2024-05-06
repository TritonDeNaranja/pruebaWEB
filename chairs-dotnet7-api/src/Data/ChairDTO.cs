public class ChairDTO
{     
    public int Id { get; set; }    
    public string? Name { get; set; } 
    public string Type {get;set;}
    public string Color {get;set;}    
    public int Altura {get;set;}
    public int Ancho {get;set;}
    public int Profundidad {get;set;}
    public int Precio {get;set;}
    public int Stock {get;set;}

    public TodoItemDTO() { }
    public TodoItemDTO(Todo todoItem) =>
    (Id, Name, Type, Color, Altura, Ancho, Profundidad, Precio, Stock) =   (chair.Id, chair.Name, chair.Type, chair.Color, chair.Altura, chair.Ancho, chair.Profundidad, chair.Precio, chair.Stock);
}

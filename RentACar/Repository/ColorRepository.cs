
using RentACar.Models;

namespace RentACar.Repository;

public class ColorRepository : IColorRepository
{
    private List<Color> _colors = new List<Color>()
    {
        new Color {Id = 1, Name = "Sarı"},
        new Color {Id = 2, Name = "Kırmızı"},
        new Color {Id = 3, Name = "Yeşil"},

    };

    public List<Color> GetAll()
    {
        return _colors;
    }

    public Color GetById(int id)
    {
        return _colors.FirstOrDefault(c => c.Id == id); 
    }
    public void Add(Color color)
    {
        _colors.Add(color);
    }
    public void Update(Color color)
    {
        var existingColor = GetById(color.Id);
        if (existingColor != null)
        {
            existingColor.Name = color.Name;
        }
    }
    public void Delete(int id)
    {
        var color = GetById(id);
        if (color != null)
        {
            _colors.Remove(color);
        }
    }
}

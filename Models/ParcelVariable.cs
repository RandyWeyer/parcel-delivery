namespace Parcel.Models
{
  public class ParcelVariable
  {
    private int _length;
    private int _width;
    private int _height;
    private int _weight;

    // public ParcelVariable(int length, int width, int height, int weight)
    // {
    //   _length = length;
    //   _width = width;
    //   _height = height;
    //   _weight = weight;
    // }
    public ParcelVariable()
    {

    }

    public int Volume()
    {
      return (_length * _width * _height);
    }

    public int CostToShip()
    {
      if (_weight > 5 || this.Volume() > 100)
      {
        return 20;
      } else if (_weight > 1 || this.Volume() > 50)
      {
        return 5;
      } else
      {
        return 1;
      }
    }

    public int GetLength()
    {
      return _length;
    }

    public void SetLength(int newLength)
    {
      _length = newLength;
    }

    public int GetWidth()
    {
      return _width;
    }

    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }

    public int GetHeight()
    {
      return _height;
    }

    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }
  }
}

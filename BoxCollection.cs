using System.Collections;

namespace AvanceradDotNetLabb1;

public class BoxCollection : ICollection<Box>
{
    private List<Box> _boxes;
    
    public BoxCollection()
    {
        _boxes = new List<Box>();
    }
    
    public Box this[int index]
    {
        get => _boxes[index];
        set => _boxes[index] = value;
    }
    
    public IEnumerator<Box> GetEnumerator()
    {
        return new BoxEnumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new BoxEnumerator(this);
    }

    public void Add(Box item)
    {
        if (!Contains(item))
        {
            _boxes.Add(item);
        }
        else
        {
            Console.WriteLine("Box already exists, not added");
        }
    }

    public void Clear()
    {
        _boxes.Clear();
    }

    public bool Contains(Box item)
    {
        // return _boxes.Contains(item);
        foreach (var box in _boxes)
        {
            if (box.Equals(item))
            {
                return true;
            }
        }
        return false;
    }
    
    public bool Contains(Box item, IEqualityComparer<Box> comparer)
    {
        foreach (var box in _boxes)
        {
            if (comparer.Equals(box, item))
            {
                return true;
            }
        }
        return false;
    }

    public void CopyTo(Box[] array, int arrayIndex)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array));
        }
        if (arrayIndex < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(arrayIndex));
        }
        if (array.Length - arrayIndex < Count)
        {
            throw new ArgumentException("Not enough space in array");
        }
        foreach (var box in _boxes)
        {
            array[arrayIndex++] = box;
        }
    }

    public bool Remove(Box item)
    {
        for (int i = 0; i < _boxes.Count; i++)
        {
            if (new BoxSameDimensions().Equals(_boxes[i], item))
            {
                _boxes.RemoveAt(i);
                return true;
            }
        }
        return false;
    }

    public int Count => _boxes.Count;
    public bool IsReadOnly => false;
}
using System.Collections;

namespace AvanceradDotNetLabb1;

public class BoxEnumerator : IEnumerator<Box>
{
    private readonly BoxCollection _boxCollection;
    private int _index;
    private Box _currentBox;
    
    public BoxEnumerator(BoxCollection boxCollection)
    {
        _boxCollection = boxCollection;
        _index = -1;
        _currentBox = default;
    }
    
    public bool MoveNext()
    {
        if (++_index >= _boxCollection.Count)
        {
            return false;
        }
        else
        {
            _currentBox = _boxCollection[_index];
            return true;
        }
    }

    public void Reset()
    {
        _index = -1;
    }

    public Box Current => _currentBox;

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        // Nothing to dispose.
    }
}
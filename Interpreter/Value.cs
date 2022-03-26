namespace PixelBasic;

public class Value
{
    public static Value FALSE = new Value(0);
    public static Value TRUE = new Value(1);
    public static Value NaN = new Value(null, true);

    private Object _value;
    private bool _isNaN;

    public Value(string value) {
        this._value = value;
    }

    public Value(int value) {
        this._value = value;
    }

    private Value(Object value, bool isNaN) {
        _value = value;
        _isNaN = isNaN;
    }

    public int internalNumber() {
        return (int)_value;
    }

    public string internalString() {
        return (string)_value;
    }

    public bool isString() {
        return _value is string;
    }

    public bool isNumber() {
        return _value is int;
    }

    public bool isNaN() {
        return _isNaN;
    }

    public bool isTrue() {
        assertNumber();
        return internalNumber() != 0;
    }

    public bool isFalse() {
        assertNumber();
        return internalNumber() == 0;
    }

    private void assertNumber() {
        if (!isNumber()) {
            throw new TypeException("Couldn't evaluate numeric expression. Value \"" + _value + "\" is not a number");
        }
    }

    public Value mul(Value right) {
        return arithmeticEval(right, (l, r) => l * r);
    }
    
    public Value div(Value right) {
        return arithmeticEval(right, (l, r) => l / r);
    }
    
    public Value mod(Value right) {
        return arithmeticEval(right, (l, r) => l % r);
    }

    public Value add(Value right) {
        if (isString() && right.isString()) {
            return new Value(internalString() + right.internalString());
        } else if (isString() && right.isNumber()) {
            return new Value(internalString() + right.internalNumber());
        } else if (isNumber() && right.isString()) {
            return new Value(internalNumber() + right.internalString());
        } else {
            return arithmeticEval(right, (l, r) => l + r);
        }
    }
    
    public Value sub(Value right) {
        return arithmeticEval(right, (l, r) => l - r);
    }
    
    private Value arithmeticEval(Value right, Func<int, int, int> oper) {
        assertNumber();
        right.assertNumber();
        return new Value(oper(internalNumber(), right.internalNumber()));
    }
    
    public Value gt(Value right) {
        return relEval(right, (l, r) => l > r);
    }
    
    public Value gte(Value right) {
        return relEval(right, (l, r) => l >= r);
    }
    
    public Value lt(Value right) {
        return relEval(right, (l, r) => l < r);
    }
    
    public Value lte(Value right) {
        return relEval(right, (l, r) => l <= r);
    }
    
    public Value eq(Value right) {
        if (isNumber() && right.isNumber()) {
            return relEval(right, (l, r) => l == r);
        } else if (isString() && right.isString()) {
            return internalString().Equals(right.internalString()) ? TRUE : FALSE;
        }
        return FALSE;
    }
    
    public Value neq(Value right) {
        // Value eq = eq(right);
        return right.Equals(TRUE) ? FALSE : TRUE;
    }
    
    private Value relEval(Value right, Func<int, int, bool> comparison) {
        assertNumber();
        right.assertNumber();
        if (comparison(internalNumber(), right.internalNumber())) {
            return TRUE;
        }
        return FALSE;
    }

    public Value not() {
        assertNumber();
        if (internalNumber() == 0) {
            return TRUE;
        }
        return FALSE;
    }

    public Value and(Value right) {
        return isTrue() && right.isTrue() ? TRUE : FALSE;
    }

    public Value or(Value right) {
        return isTrue() || right.isTrue() ? TRUE : FALSE;
    }

    public Value exp(Value right) {
        assertNumber();
        right.assertNumber();
        return new Value((int)Math.Round(Math.Pow(internalNumber(), right.internalNumber())));
    }

    public override bool Equals(object? obj)
    {
        if (this == obj) return true;
        if (!(obj is Value)) return false;

        Value value1 = (Value) obj;

        if (_isNaN != value1._isNaN) return false;
        return _value != null ? _value.Equals(value1._value) : value1._value == null;
    }

    public override int GetHashCode()
    {
        int result = _value != null ? _value.GetHashCode().GetHashCode() : 0;
        result = 31 * result + (_isNaN ? 1 : 0);
        return result;
    }

}
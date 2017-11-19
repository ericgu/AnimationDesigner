struct uint16_t
{
    ushort _value;

    public uint16_t(ushort u)
    {
        _value = u;
    }

    public static implicit operator uint16_t(ushort u)
    {
        return new uint16_t(u);
    }

    public static implicit operator ushort(uint16_t u)
    {
        return u._value;
    }
}

struct uint8_t
{
    byte _value;

    public uint8_t(byte u)
    {
        _value = u;
    }

    public static implicit operator uint8_t(byte u)
    {
        return new uint8_t(u);
    }

    public static implicit operator byte (uint8_t u)
    {
        return u._value;
    }

    public override string ToString()
    {
        return _value.ToString();
    }
}


struct uint32_t
{
    uint _value;

    public uint32_t(uint u)
    {
        _value = u;
    }

    public static implicit operator uint32_t(uint u)
    {
        return new uint32_t(u);
    }

    public static implicit operator uint (uint32_t u)
    {
        return u._value;
    }
}


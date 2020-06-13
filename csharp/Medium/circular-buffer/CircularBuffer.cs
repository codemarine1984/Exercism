﻿using System;
using System.Collections.Generic;
using System.Linq;

public class CircularBuffer<T>
{
    private T[] bufferArray;
    private int bufferSize;
    private int readIndex;
    private int writeIndex;

    public CircularBuffer(int capacity)
    {
        bufferArray = new T[capacity];
        bufferSize = capacity;
        readIndex = 0;
        writeIndex = 0;
    }

    public T Read()
    {
        if(bufferArray.Where(x => x.Equals(default(T))).Count() == bufferSize)
        {
            throw new InvalidOperationException("Cannot read from an empty buffer.");
        }

        var result = bufferArray.ElementAt(readIndex);
        bufferArray[readIndex] = default(T);

        readIndex++;
        if (readIndex == bufferSize) readIndex = 0;

        return result;
    }

    public void Write(T value)
    {
        if (!bufferArray[writeIndex].Equals(default(T)))
        {
            throw new InvalidOperationException("Cannot write to a full buffer.");
        }

        bufferArray[writeIndex] = value;

        writeIndex++;
        if (writeIndex == bufferSize) writeIndex = 0;
    }

    public void Overwrite(T value)
    {
        if (!bufferArray[writeIndex].Equals(default(T)))
        {
            bufferArray[writeIndex] = default(T);
            readIndex = writeIndex + 1;
            if (readIndex == bufferSize) readIndex = 0;
        }  
        Write(value);
        
    }

    public void Clear()
    {
        for(var i = 0; i < bufferSize; i++)
        {
            bufferArray[i] = default(T);
        }
        readIndex = 0;
        writeIndex = 0;
    }
}
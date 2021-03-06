// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Threading;

public class Test
{

    public static int Main()
    {
        try
        {
            Monitor.Wait(null, 0);
            Console.WriteLine("Failed to throw exception on Monitor.Wait");
            return 1;
        }
        catch(ArgumentNullException)
        {
            //Expected            
        }
        return 100;
    }
}


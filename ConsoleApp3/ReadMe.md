# Markdown File

#Imp points

1. GCD 
`

   public int GCF(int a, int b)
        {
            int rem = a % b;
            if (rem == 0)
            {
                return b;
            }
            return GCF(b, a % b);
        }
    }
`
2. Prefix Sums.
> A[i,j] = PS[j] - PS[i-1]
> A[i,j] sum of elements from i to j
> PS is prefix sum array 
Sum(Arr[i,j]) = A[j] - A[i-1]

Sum of elements in Arr from i to j;

A is preFixSum Array

Arr = [6,3,-2,4,-1,0,5]  

A = [6,9,7,11,10,10,15]

A[i] = Arr[i]+Arr[i-1] where i> 0

A[i] = Arr[i] where i = 0;

3. To convert an int to byte[]. First Convert it to string using Conver.ToString(int , base);



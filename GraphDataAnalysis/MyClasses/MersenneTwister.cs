namespace GraphDataAnalysis.MyClasses
{
	public class MersenneTwister
	{
		// Period parameters  
		const int N = 624;
		const int M = 397;
		const ulong MatrixA = 0x9908b0dfUL;    // constant vector a
		const ulong UpperMask = 0x80000000UL;  // most significant w-r bits
		const ulong LowerMask = 0x7fffffffUL;  // least significant r bits
		private readonly ulong[] _mt = new ulong[N];  // the array for the state vector
		private int _mti = N + 1;            // mti==N+1 means mt[N] is not initialized
		public MersenneTwister() { init_by_array(new ulong[] { 0x123, 0x234, 0x345, 0x456 }); } // set default seeds
		public MersenneTwister(ulong s) { init_genrand(s); }
		public MersenneTwister(ulong[] initKey) { init_by_array(initKey); }
		// initializes mt[N] with a seed
		public void init_genrand(ulong s)
		{
			_mt[0] = s & 0xffffffffUL;
			for (_mti = 1; _mti < N; _mti++)
			{
				_mt[_mti] = (1812433253UL * (_mt[_mti - 1] ^ (_mt[_mti - 1] >> 30)) + (ulong)_mti);
				/* See Knuth TAOCP Vol2. 3rd Ed. P.106 for multiplier. */
				/* In the previous versions, MSBs of the seed affect   */
				/* only MSBs of the array mt[].                        */
				/* 2002/01/09 modified by Makoto Matsumoto             */
				_mt[_mti] &= 0xffffffffUL;
				/* for >32 bit machines */
			}
		}
		// initialize by an array with array-length
		// init_key is the array for initializing keys
		// init_key.Length is its length
		public void init_by_array(ulong[] initKey)
		{
			init_genrand(19650218UL);
			int i = 1;
			int j = 0;
			int k = (N > initKey.Length ? N : initKey.Length);
			for (; k != 0; k--)
			{
				_mt[i] = (_mt[i] ^ ((_mt[i - 1] ^ (_mt[i - 1] >> 30)) * 1664525UL)) + initKey[j] + (ulong)j; /* non linear */
				_mt[i] &= 0xffffffffUL; /* for WORDSIZE > 32 machines */
				i++; j++;
				if (i >= N) { _mt[0] = _mt[N - 1]; i = 1; }
				if (j >= initKey.Length) { j = 0; }
			}
			for (k = N - 1; k != 0; k--)
			{
				_mt[i] = (_mt[i] ^ ((_mt[i - 1] ^ (_mt[i - 1] >> 30)) * 1566083941UL)) - (ulong)i; // non linear
				_mt[i] &= 0xffffffffUL; // for WORDSIZE > 32 machines
				i++;
				if (i >= N) { _mt[0] = _mt[N - 1]; i = 1; }
			}
			_mt[0] = 0x80000000UL; // MSB is 1; assuring non-zero initial array 
		}
		// generates a random number on [0,0xffffffff]-interval
		public ulong genrand_uint32()
		{
			ulong[] mag01 = { 0x0UL, MatrixA };
			ulong y;
			// mag01[x] = x * MATRIX_A  for x=0,1
			if (_mti >= N)
			{   // generate N words at one time
				int kk;
				if (_mti == N + 1)
				{           // if init_genrand() has not been called,
					init_genrand(5489UL);   // a default initial seed is used
				}
				for (kk = 0; kk < N - M; kk++)
				{
					y = (_mt[kk] & UpperMask) | (_mt[kk + 1] & LowerMask);
					_mt[kk] = _mt[kk + M] ^ (y >> 1) ^ mag01[y & 0x1UL];
				}
				for (; kk < N - 1; kk++)
				{
					y = (_mt[kk] & UpperMask) | (_mt[kk + 1] & LowerMask);
					_mt[kk] = _mt[kk + (M - N)] ^ (y >> 1) ^ mag01[y & 0x1UL];
				}
				y = (_mt[N - 1] & UpperMask) | (_mt[0] & LowerMask);
				_mt[N - 1] = _mt[M - 1] ^ (y >> 1) ^ mag01[y & 0x1UL];
				_mti = 0;
			}
			y = _mt[_mti++];
			// Tempering
			y ^= (y >> 11);
			y ^= (y << 7) & 0x9d2c5680UL;
			y ^= (y << 15) & 0xefc60000UL;
			y ^= (y >> 18);
			return y;
		}
		// generates a random floating point number on [0,1]
		public double genrand_real1()
		{
			return genrand_uint32() * (1.0 / 4294967295.0); // divided by 2^32-1
		}
		// generates a random floating point number on [0,1)
		public double genrand_real2()
		{
			return genrand_uint32() * (1.0 / 4294967296.0); // divided by 2^32
		}
		// generates a random integer number from 0 to N-1
		public int genrand_N(int iN)
		{
			return (int)(genrand_uint32() * (iN / 4294967296.0));
		}
	}
}

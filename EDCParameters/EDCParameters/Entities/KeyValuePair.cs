﻿using System;

namespace EDCParameters
{
	public struct KeyValuePair<TKey, TValue> {
		private TKey key;
		private TValue value;

		public KeyValuePair(TKey key, TValue value) {
			this.key = key;
			this.value = value;
		}

		public TKey Key {
			get { return key; }
		}

		public TValue Value {
			get { return value; }
		}
	}
}

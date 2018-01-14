using System;
namespace CrackingTheCoding
{
    public class ResizableArray
    {
        private int[] items = new int[10];
        private int size = 0;

        public int Size() {
            return this.size;
        }

        public void Set(int index, int item) {
            if (index < 0 || index >= size) {
                throw new ArgumentOutOfRangeException();
            }
            items[index] = item;
        }

        public void Append(int item) {
            this.EnsureExtraCapacity();
            this.items[size] = item;
            size++;
        }

		public void EnsureExtraCapacity()
		{
            if (size == items.Length) {
                int[] copy = new int[size * 2];
                Array.Copy(items, copy, size);
                items = copy;
            }
		}

        public int Get(int index){
            if (index < 0 || index >= size) {
                throw new ArgumentOutOfRangeException();
            }
            return this.items[index];
        }
    }
}

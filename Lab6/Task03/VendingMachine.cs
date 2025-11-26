

namespace Lab06.Task03 {
    public class VendingMachine
    {
        private int _coin1;
        private int _coin2;
        private int _coin5;


        public int Amount
        {
            get
            {
                return _coin1 * 1 + _coin2 * 2 + _coin5 * 5;
            }
        }

        public void InsertCoin(int coin)
        {
            switch (coin)
            {
                case 1:
                    _coin1++;
                    break;
                case 2:
                    _coin2++;
                    break;
                case 5:
                    _coin5++;
                    break;
                default:
                    break;
            }
        }

    }
}
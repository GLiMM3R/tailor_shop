using System;
using Timer = System.Windows.Forms.Timer;

namespace app.Utils
{
    public class Debouncer : IDisposable
    {
        private readonly Timer _timer;
        private readonly Action _debouncedAction;

        public Debouncer(int delayMs, Action action)
        {
            _debouncedAction = action ?? throw new ArgumentNullException(nameof(action));
            _timer = new Timer
            {
                Interval = delayMs,
                Enabled = false
            };
            _timer.Tick += Timer_Tick;
        }

        public void Trigger()
        {
            _timer.Stop();
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            _debouncedAction?.Invoke();
        }

        public void Dispose()
        {
            _timer?.Stop();
            _timer?.Dispose();
        }
    }
}

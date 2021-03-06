﻿using System.Threading.Tasks;

namespace FFMpegCore.Test
{
    static class TasksExtensions
    {
        public static T WaitForResult<T>(this Task<T> task) =>
            task.ConfigureAwait(false).GetAwaiter().GetResult();
    }
}

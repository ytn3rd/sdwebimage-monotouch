using System;

namespace SDWebImage
{
	public enum SDWebImageOptions
	{
		SDWebImageRetryFailed = 1 << 0,
		SDWebImageLowPriority = 1 << 1,
		SDWebImageCacheMemoryOnly = 1 << 2,
		SDWebImageProgressiveDownload = 1 << 3,
        None = 0
	}

    public enum SDImageCacheType
    {
        SDImageCacheTypeNone = 0,
        SDImageCacheTypeDisk,
        SDImageCacheTypeMemory
    }
}


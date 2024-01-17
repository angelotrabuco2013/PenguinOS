﻿using System;

namespace IMAPI2.Interop
{
	// Token: 0x0200001E RID: 30
	public enum IMAPI_MODE_PAGE_TYPE
	{
		// Token: 0x04000104 RID: 260
		IMAPI_MODE_PAGE_TYPE_READ_WRITE_ERROR_RECOVERY = 1,
		// Token: 0x04000105 RID: 261
		IMAPI_MODE_PAGE_TYPE_MRW = 3,
		// Token: 0x04000106 RID: 262
		IMAPI_MODE_PAGE_TYPE_WRITE_PARAMETERS = 5,
		// Token: 0x04000107 RID: 263
		IMAPI_MODE_PAGE_TYPE_CACHING = 8,
		// Token: 0x04000108 RID: 264
		IMAPI_MODE_PAGE_TYPE_POWER_CONDITION = 26,
		// Token: 0x04000109 RID: 265
		IMAPI_MODE_PAGE_TYPE_TIMEOUT_AND_PROTECT = 29,
		// Token: 0x0400010A RID: 266
		IMAPI_MODE_PAGE_TYPE_INFORMATIONAL_EXCEPTIONS = 28,
		// Token: 0x0400010B RID: 267
		IMAPI_MODE_PAGE_TYPE_LEGACY_CAPABILITIES = 42
	}
}

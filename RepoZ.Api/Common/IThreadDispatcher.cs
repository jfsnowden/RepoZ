﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoZ.Api.Common
{
	public interface IThreadDispatcher
	{
		void Invoke(Action act);
	}
}

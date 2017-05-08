﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoZ.Api.IO;

namespace RepoZ.Api.Win.IO
{
	public class DefaultPathCrawlerFactory : IPathCrawlerFactory
	{
		private IPathSkipper _pathSkipper;

		public DefaultPathCrawlerFactory(IPathSkipper pathSkipper)
		{
			_pathSkipper = pathSkipper;
		}

		public IPathCrawler Create() => new GravellPathCrawler(_pathSkipper);
	}
}

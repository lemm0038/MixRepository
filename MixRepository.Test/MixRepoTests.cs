using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MixRepository.Common.Model;


namespace MixRepository.Common.Data
{
	[TestClass]
	public class MixRepoTests
	{
		[TestMethod]
		public void TestAddMix()
		{
				var repo = new MixRepository();
				var mix = new Mix();
				mix.MixName = "Test";
				mix.Ratio = "1:1";
				repo.Add(new List<Mix>() { mix });
		}

		[TestMethod]
		public void TestAddMixEmptyList()
		{
			var repo = new MixRepository();
			var mixList = new List<Mix>();
			repo.Add(mixList);
		}

		[TestMethod]
		public void TestAddMixMissingProperty()
		{
			var repo = new MixRepository();
			var mix = new Mix();
			mix.MixName = "Test";
			mix.Ratio = "1:2";
			var mixList = new List<Mix>();
			mixList.Add(mix);
			repo.Add(mixList);
		}
	}
}

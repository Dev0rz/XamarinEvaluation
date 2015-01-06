/// <summary>
/// Könnte verwendet werden um Datenbankobjekte und Files etc. automatisch auf das Domänenobjekt zu mappen.
/// </summary>
using System;
using AutoMapper;

namespace App.Data
{
	public class Source
	{
		public int SomeValue { get; set; }
	}

	public class Destination
	{
		public int SomeValuefff { get; set; }
	}

	public class TestAutoMapper
	{
		public TestAutoMapper ()
		{

		}

		public void Test ()
		{
			Mapper.CreateMap<Source, Destination>();

			Mapper.AssertConfigurationIsValid();

		}
	}

	public class TestTable
	{
		public TestAutoMapper ()
		{

		}

		public void Test ()
		{
			Mapper.CreateMap<Source, Destination>();

			Mapper.AssertConfigurationIsValid();

		}
	}
}


﻿using System;

namespace CCExtractorTester
{
	public interface Ilogger
	{
		void Info(string message);
		void Warn(string message);
		void Error(string message);
		void Error(Exception e);
		void Debug(string message);
	}
}
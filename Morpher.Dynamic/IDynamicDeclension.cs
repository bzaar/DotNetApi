﻿namespace Morpher
{
    public interface IDynamicDeclension
    {
		string GetCase (string phrase, string @case, string rod = null);
    }
}
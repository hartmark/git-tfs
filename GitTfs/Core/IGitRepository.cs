﻿using System.Collections.Generic;

namespace Sep.Git.Tfs.Core
{
    public interface IGitRepository : IGitHelpers
    {
        IList<string> ReadAllRemotes();
    }
}

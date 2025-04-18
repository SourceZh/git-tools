﻿using System.Collections.Generic;

namespace VSIXProject2022
{
    class GitToolCommand
    {
        public CommandScope Scope { get; set; }
        public string Name { get; set; }
        public string Command { get; set; }

        public GitToolCommand(string name, string Command, CommandScope scope = CommandScope.Project)
        {
            this.Name = name;
            this.Command = Command;
            Scope = scope;
        }
    }

    public enum CommandScope
    {
        File, Project
    }

    static class GitToolCommands
    {
        internal static List<GitToolCommand> GitTorCommands = new List<GitToolCommand> {
            new GitToolCommand("TortoiseGit", "/command:log"),
            new GitToolCommand("Commit", "/command:commit"),
            new GitToolCommand("Pull", "/command:pull"),
            new GitToolCommand("Fetch", "/command:fetch"),
            new GitToolCommand("Push", "/command:push"),
            new GitToolCommand("Show Log", "/command:log", CommandScope.File),
            new GitToolCommand("Show ReLog", "/command:reflog"),
            new GitToolCommand("Blame", "/command:blame", CommandScope.File),
            new GitToolCommand("Diff", "/command:diff"),
            new GitToolCommand("Revert", "/command:revert"),
            new GitToolCommand("Switch", "/command:switch"),
            new GitToolCommand("Merge", "/command:merge"),
            new GitToolCommand("Branch", "/command:branch"),
            new GitToolCommand("Sync", "/command:sync"),
            new GitToolCommand("Stash Save", "/command:stashsave"),
            new GitToolCommand("Stash Pop", "/command:stashpop"),
            new GitToolCommand("Stash List", "/command:reflog /ref:refs/stash"),
        };

        internal static List<GitToolCommand> GitExtCommands = new List<GitToolCommand> {
            new GitToolCommand("Git Extensions", "browse"),
            new GitToolCommand("Add Files", "add"),
            new GitToolCommand("Apply Patch", "applypatch"),
            new GitToolCommand("Browse", "browse"),
            new GitToolCommand("Create Branch", "branch"),
            new GitToolCommand("Checkout Branch", "checkout"),
            new GitToolCommand("Cherry Pick", "cherry"),
            new GitToolCommand("Commit", "commit"),
            new GitToolCommand("Edit .gitignore", "gitignore"),
            new GitToolCommand("Format Patch", "formatpatch"),
            new GitToolCommand("Manage Remotes", "remotes"),
            new GitToolCommand("Merge", "merge"),
            new GitToolCommand("Pull", "pull"),
            new GitToolCommand("Push", "push"),
            new GitToolCommand("Rebase", "rebase"),
            new GitToolCommand("Stash", "stash"),
            new GitToolCommand("Settings", "settings"),
            new GitToolCommand("Solve Merge Conflicts", "mergeconflicts"),
        };

    }
}

﻿namespace WebAppMarkdown.Db.Models;

public class UserEntity
{
    public Guid Id { get; set; }
    
    public string Username { get; set; }
    
    public string Email { get; set; }

    public string PasswordHash { get; set; }

    public List<DocumentEntity> MarkdownEntries { get; set; } = [];

}
import React, { Component } from 'react';
import { Card, Spinner } from 'react-bootstrap';

export class FetchData extends Component {
  displayName = FetchData.name

  constructor(props) {
    super(props);
    this.state = { forecasts: [], loading: true };

    fetch('api/textpost')
      .then(response => response.json())
      .then(data => {
        this.setState({ posts: data, loading: false });
        console.log(data);
      });
  }

  static renderPosts(posts) {
    return (
    <div>
      {posts.map(posts =>
      <Card bg="dark" text="white" style={{marginBottom:10, borderRadius: 0}}>
        <Card.Body key={posts.id}>
          <Card.Title>{posts.title}</Card.Title>
          <Card.Subtitle className="mb-2 text-muted">{posts.user}</Card.Subtitle>
          <Card.Text>
            {posts.content}
          </Card.Text>
          <td>{posts.datePosted}</td>
          <Card.Link href="#">{posts.likes}</Card.Link>
        </Card.Body>
      </Card>
      )}
    </div>
    );
  }

  render() {
    let contents = this.state.loading
      ? <Spinner animation="border" role="status">
      <span className="sr-only">Loading...</span>
    </Spinner>
      : FetchData.renderPosts(this.state.posts);

    return (
      <div>
        <h1>Posts</h1>
        {contents}
      </div>
    );
  }
}

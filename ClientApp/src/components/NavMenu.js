import React, { Component } from 'react';
import { Nav, Navbar, NavItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';

export class NavMenu extends Component {

  render() {
    return (
      <Navbar bg="dark" variant="dark">
        <Navbar.Brand href="#home">Navbar</Navbar.Brand>
        <Nav className="mr-auto">
            <LinkContainer to={'/'} exact>
              <Nav.Link>Home</Nav.Link>
            </LinkContainer>
            <LinkContainer to={'/fetchdata'}>
              <Nav.Link>Posts</Nav.Link>
            </LinkContainer>
        </Nav>
      </Navbar>
    );
  }
}
